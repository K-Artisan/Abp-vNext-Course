# Abp-vNext  Course

前言



目录

[TOC]



## 框架初识

### 概述

- 网站资源

  官网：http://abp.io

  文档：https://docs.abp.io/en/abp/latest

  Github：https://github.com/abpframework/abp/

  

- xxx



### 脚手架

- 安装

  ```powershell
  dotnet tool install -g Volo.Abp.Cli
  ```

- 更新最新版本

  ```powershell
  dotnet tool update -g Volo.Abp.Cli
  ```

- abp help 

  ```C#
  abp help 
  abp help new
  ```
  
  
  
- 文档

  https://docs.abp.io/zh-Hans/abp/latest/CLI



### 创建项目

 使用ABP CLI的 `new` 命令创建新项目: 

```powershell
abp new Acme.BookStore --mobile react-native
```

创建模块

```c#
abp new Zo.Abp.Course.Sample -t module
```



## 模块化





## 依赖注入

#### 文档

https://docs.abp.io/zh-Hans/abp/latest/Dependency-Injection

#### 教程

Course-03



#### 概述

基于ASP.NET Core DI框架
组件自动注册
模块化
高级特性
第三方DI框架（Autofac）



### 依照约定的注册

ABP引入了依照约定的服务注册.依照约定你无需做任何事,它会自动完成.如果要禁用它,你可以通过重写`PreConfigureServices`方法,设置`SkipAutoServiceRegistration`为`true`.

```csharp
public class BlogModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        SkipAutoServiceRegistration = true;
    }
}
```



#### 组件自动注册

- SkipAutoServiceRegistration
- AddAssemblyOf<T>
- AddAssembly

当`SkipAutoServiceRegistration=true`, 不会自动调用

```C#
AddAssemblyOf<T>
```

或者

```C#
AddAssembly
```

进行注册。

 一旦跳过自动注册,你应该手动注册你的服务.在这种情况下,`AddAssemblyOf`扩展方法可以帮助你依照约定注册所有服务.例: 

```csharp
public class BlogModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        SkipAutoServiceRegistration = true;
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAssemblyOf<BlogModule>();
    }
}
```



#### 固有的注册类型

一些特定类型会默认注册到依赖注入.例子:

- 模块类注册为singleton.
- MVC控制器（继承`Controller`或`AbpController`）被注册为transient.
- MVC页面模型（继承`PageModel`或`AbpPageModel`）被注册为transient.
- MVC视图组件（继承`ViewComponent`或`AbpViewComponent`）被注册为transient.
- 应用程序服务（实现`IApplicationService`接口或继承`ApplicationService`类）注册为transient.
- 存储库（实现`IRepository`接口）注册为transient.
- 域服务（实现`IDomainService`接口）注册为transient.



#### 依赖接口

如果实现这些接口,则会自动将类注册到依赖注入:

- `ITransientDependency` 注册为transient生命周期.
- `ISingletonDependency` 注册为singleton生命周期.
- `IScopedDependency` 注册为scoped生命周期.



##### 示例1：自动注入

 实现接口的所有的实现类都会被注入，


```C#
var userServices = app.ServiceProvider.GetServices<IUserService>();
Console.WriteLine("-------实现接口的所有的实现类都会被注入,----------");
foreach (var service in userServices)
{
    Console.WriteLine(service?.SayHello(null));
}

```

输出：

```powershell
-------实现接口的所有的实现类都会被注入,----------
Hello CustomeUserService !
Hello UserService !
```

但是相同的后缀的不会被自动注入，例如：`UserService`, `UserService1`, `UserService2`,只会注入`UserService`,

 除非显示注入：

```C#
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddTransient<IUserService, UserService3>();
        }
```

才会 注入`UserService3`。这时的输出是：

```powershell
-------实现接口的所有的实现类都会被注入,----------
Hello CustomeUserService !
Hello UserService !
Hello UserService3 !
```



##### 示例2：生命周期

```C#
public class GuidService : ITransientDependency //, ISingletonDependency, IScopedDependency
{
    private readonly Guid guid;
    public GuidService()
    {
        guid = Guid.NewGuid();
    }

    public string GetId()
    {
        return guid.ToString("N");
    }
}
```






####  Dependency 特性

配置依赖注入服务的另一种方法是使用`DependencyAttribute`.它具有以下属性:

- `Lifetime`: 注册的生命周期:Singleton,Transient或Scoped.
- `TryRegister`: 设置`true`则只注册以前未注册的服务.使用IServiceCollection的TryAdd ... 扩展方法.
- `ReplaceServices`: 设置`true`则替换之前已经注册过的服务.使用IServiceCollection的Replace扩展方法.



#### ExposeServices 特性

 `ExposeServicesAttribute`用于控制相关类提供了什么服务.例: 

```csharp
[ExposeServices(typeof(ITaxCalculator))]
public class TaxCalculator: ICalculator, ITaxCalculator, ICanCalculate, ITransientDependency
{

}
```

`TaxCalculator`类只公开`ITaxCalculator`接口.这意味着你只能注入`ITaxCalculator`,但不能注入`TaxCalculator`或`ICalculator`到你的应用程序中.



### 手动注册

 在某些情况下,你可能需要向`IServiceCollection`手动注册服务,尤其是在需要使用自定义工厂方法或singleton实例时.在这种情况下,你可以像[Microsoft文档](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection)描述的那样直接添加服务.例: 

```csharp
public class BlogModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        //注册一个singleton实例
        context.Services.AddSingleton<TaxCalculator>(new TaxCalculator(taxRatio: 0.18));

        //注册一个从IServiceProvider解析得来的工厂方法
        context.Services.AddScoped<ITaxCalculator>(sp => sp.GetRequiredService<TaxCalculator>());
    }
}
```



### 高级特性

IServiceCollection.OnRegistred

使用第三方提供的程序（AutoFac）实现

- 在注册到依赖注入的每个服务上执行一个操作
- 通常用于向服务添加拦截器 ，AOP



例如：`AbpUnitOfWorkModule` 类

```C#
namespace Volo.Abp.Uow
{
    public class AbpUnitOfWorkModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
           context.Services.OnRegistred(UnitOfWorkInterceptorRegistrar.RegisterIfNeeded);
        }
    }
}
```

```C#
namespace Volo.Abp.Uow
{
    public static class UnitOfWorkInterceptorRegistrar
    {
        public static void RegisterIfNeeded(IOnServiceRegistredContext context)
        {
            if (ShouldIntercept(context.ImplementationType))
            {
                context.Interceptors.TryAdd<UnitOfWorkInterceptor>();
            }
        }
        
        private static bool ShouldIntercept(Type type)
        {
            return !DynamicProxyIgnoreTypes.Contains(type) && UnitOfWorkHelper.IsUnitOfWorkType(type.GetTypeInfo());
        }
    }
}
```



### 第三方集成

- AutoFac

  

## Options

### 文档

Abp: https://docs.abp.io/zh-Hans/abp/latest/Dependency-Injection

- Net：https://docs.microsoft.com/zh-cn/aspnet/core/fundamentals/configuration/options?view=aspnetcore-5.0



### 配置选项

在Asp.Net 中， 使用如下方法添加配置到了服务容器 

     ```C#
public void ConfigureServices(IServiceCollection services)
{
    services.Configure<PositionOptions>(Configuration.GetSection(
                                        PositionOptions.Position));
}
     ```

 通过使用前面的代码，以下代码将读取位置选项： 

```C#
public class Test2Model : PageModel
{
    private readonly PositionOptions _options;

    public Test2Model(IOptions<PositionOptions> options)
    {
        _options = options.Value;
    }

    public ContentResult OnGet()
    {
        return Content($"Title: {_options.Title} \n" +
                       $"Name: {_options.Name}");
    }
}
```



通常配置选项在 `Startup` 类的 `ConfigureServices` 方法中. 但由于ABP框架提供了模块化基础设施,因此你可以在[模块](https://docs.abp.io/zh-Hans/abp/latest/Module-Development-Basics)的`ConfigureServices` 方法配置选项. 例: 

```csharp
public override void ConfigureServices(ServiceConfigurationContext context)
{
    context.Services.Configure<AbpAuditingOptions>(options =>
    {
        options.IsEnabled = false;
    });
}
```

- `AbpAuditingOptions` 是一个简单的类,定义了一些属性,例如这里使用的 `IsEnabled`.

- `AbpModule` 基类定义 `Configure` 方法简化代码. 你可以直接使用 `Configure<...>`,而不是`context.Services.Configure <...>`.

  

  如果你正在开发一个可重用的模块,你可能需要定义一个允许开发人员配置模块的选项类. 这时定义一个如下所示的普通类:

  ```csharp
  public class MyOptions
  {
      public int Value1 { get; set; }
      public bool Value2 { get; set; }
  }
  ```

  然后开发人员可以像上面 `AbpAuditingOptions` 示例一样配置你的选项:

  ```csharp
  public override void ConfigureServices(ServiceConfigurationContext context)
  {
      Configure<MyOptions>(options =>
      {
          options.Value1 = 42;
          options.Value2 = true;
      });
  }
  ```



### 获取选项值

 在你需要获得一个选项值时,将 `IOptions` 服务[注入](https://docs.abp.io/zh-Hans/abp/latest/Dependency-Injection)到你的类中,使用它的 `.Value` 属性得到值. 例: 

```csharp
public class MyService : ITransientDependency
{
    private readonly MyOptions _options;

    public MyService(IOptions<MyOptions> options)
    {
        _options = options.Value; //Notice the options.Value usage!
    }

    public void DoIt()
    {
        var v1 = _options.Value1;
        var v2 = _options.Value2;
    }
}
```



### 预配置

 选项模式的限制之一是你只能解析(注入) `IOptions ` 并在依赖注入配置完成(即所有模块的`ConfigureServices`方法完成)后获取选项值. 

 如果你正在开发一个模块,可能需要让开发者能够设置一些选项,**并在依赖注入注册阶段使用这些选项**. 你可能需要根据选项值配置其他服务或更改依赖注入的注册代码. 

 对于此类情况,ABP为 `IServiceCollection` 引入了 `PreConfigure` 和 `ExecutePreConfiguredActions` 扩展方法. 该模式的工作原理如下所述. 

- 在你的模块中定义预先选项类. 例: 

```csharp
public class MyPreOptions
{
    public bool MyValue { get; set; }
}
```

-  然后任何依赖于模块的模块类都可以在其 `PreConfigureServices` 方法中使用 `PreConfigure` 方法. 例: 

```csharp
public override void PreConfigureServices(ServiceConfigurationContext context)
{
    PreConfigure<MyPreOptions>(options =>
    {
        options.MyValue = true;
    });
}
```

-  最后在你的模块 `ConfigureServices` 方法中执行 `ExecutePreConfiguredActions` 方法来获得配置的选项值. 例: 

```csharp
public override void ConfigureServices(ServiceConfigurationContext context)
{
    var options = context.Services.ExecutePreConfiguredActions<MyPreOptions>();
    if (options.MyValue)
    {
        //...
    }
}
```



示例：

- 新建类库项目: Zo.Abp.Course.Options

  `ApplicationModule`

```C#
namespace Zo.Abp.Course.Options
{
    public class ApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var connectionStringOptions =        context.Services.ExecutePreConfiguredActions<ConnectionStringOptions>();
            context.Services.AddDbContext<AppDbContext>(options => {
                options.UseSqlServer(connectionStringOptions.ConnectionString);
            });
        }
    }
}

...
    
    public class ConnectionStringOptions
    {
        public string ConnectionString { get; set; }
    }

```



- 新建控制台项目：Zo.Abp.Course03.Options.Host

  `HostModule`:

```C#
namespace Zo.Abp.Course03.Options.Host
{
    [DependsOn(typeof(ApplicationModule))]
    public class HostModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.PreConfigure<ConnectionStringOptions>(options =>
            {
                options.ConnectionString = "Data Source=.; Initial Catalog=AbpDb; User ID=sa; Password=******;";
            });
        }
    }
}
```

​       `main.cs`:

```C#
    class Program
    {
        static void Main(string[] args)
        {
            using(var app = AbpApplicationFactory.Create<HostModule>())
            {
                app.Initialize();

                var db = app.ServiceProvider.GetService<AppDbContext>();
                Console.WriteLine(db.Database.GetDbConnection().ConnectionString);
            }
        }
    }
```

输出：

```powershell
Data Source=.; Initial Catalog=AbpDb; User ID=sa; Password=******;
```



## DDD

### 文档：

abp:https://docs.abp.io/zh-Hans/abp/latest/Domain-Driven-Design



### 教程

Course-04



### 概述

![1610286268881](images/Abp-vNext%20Course/1610286268881.png)

<img src="images/Abp-vNext%20Course/1610286280842.png" alt="1610286280842" style="zoom:100%;" />



### 示例

#### 脚手架

```powershell
abp help new
```

输出：

```powershell
Usage:

  abp new <project-name> [options]

Options:

-t|--template <template-name>               (default: app)
-u|--ui <ui-framework>                      (if supported by the template)
-m|--mobile <mobile-framework>              (if supported by the template)
-d|--database-provider <database-provider>  (if supported by the template)
-o|--output-folder <output-folder>          (default: current folder)
-v|--version <version>                      (default: latest version)
--preview                                   (Use latest pre-release version if there is at least one pre-release after latest stable version)
-ts|--template-source <template-source>     (your local or network abp template source)
-csf|--create-solution-folder               (default: true)
-cs|--connection-string <connection-string> (your database connection string)
--tiered                                    (if supported by the template)
--no-ui                                     (if supported by the template)
--no-random-port                            (Use template's default ports)
--separate-identity-server                  (if supported by the template)
--local-framework-ref --abp-path <your-local-abp-repo-path>  (keeps local references to projects instead of replacing with NuGet package references)

Examples:

  abp new Acme.BookStore
  abp new Acme.BookStore --tiered
  abp new Acme.BookStore -u angular
  abp new Acme.BookStore -u angular -d mongodb
  abp new Acme.BookStore -m none
  abp new Acme.BookStore -m react-native
  abp new Acme.BookStore -d mongodb
  abp new Acme.BookStore -d mongodb -o d:\my-project
  abp new Acme.BookStore -t module
  abp new Acme.BookStore -t module --no-ui
  abp new Acme.BookStore -t console
  abp new Acme.BookStore -ts "D:\localTemplate\abp"
  abp new Acme.BookStore -csf false
  abp new Acme.BookStore --local-framework-ref --abp-path "D:\github\abp"
  abp new Acme.BookStore --connection-string "Server=myServerName\myInstanceName;Database=myDatabase;User Id=myUsername;Password=myPassword"

```

#### 创建项目

创建Module模板项目

```C#
 abp new Zo.Abp.Course.Product -t module -v 3.2.1
```

或者

创建app模板

```C#
abp new Zo.Abp.Course.Product -v 3.2.1
```



#### Product

```C#
    public class Product : FullAuditedAggregateRoot<Guid>
    {
        public Product()
        {
            Skus = new List<ProductSku>();
        }

        public string Name { get; set; }
        public string BarCode { get; set; }
        public Guid Provider { get; set; }
        public string Description { get; set; }
        public virtual ICollection<ProductSku> Skus { get; set; }

    }
```



#### ProductSku

```C#
      public class ProductSku : Entity<long>
    {
        public string ModalNo { get; set; }

        //不要写这个属性，领域层不要关注数据库设计，
        //若是MogoDb可能不需要外键，
        //要设计外键，请在.EntityFrameworkCore设置
        // public Guid ProductId { get; set; } 
    }	 	
```

**特别注意**：

​		不要定义属性`ProductId`，领域层不要关注数据库设计

