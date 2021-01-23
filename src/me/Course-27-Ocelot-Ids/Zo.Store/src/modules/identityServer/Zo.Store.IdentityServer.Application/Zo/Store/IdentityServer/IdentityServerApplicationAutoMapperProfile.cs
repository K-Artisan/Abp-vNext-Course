using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.IdentityServer.ApiResources;
using Volo.Abp.IdentityServer.ApiScopes;
using Volo.Abp.IdentityServer.Clients;
using Volo.Abp.IdentityServer.IdentityResources;
using Zo.Store.IdentityServer.ApiResources;
using Zo.Store.IdentityServer.Clients;
using Zo.Store.IdentityServer.IdentityResources;

namespace Zo.Store.IdentityServer
{
    public class IdentityServerApplicationAutoMapperProfile : Profile
    {
        public IdentityServerApplicationAutoMapperProfile()
        {
            CreateMap<ClientSecret, ClientSecretDto>();
            CreateMap<ClientClaim, ClientClaimDto>();
            CreateMap<List<ClientProperty>, Dictionary<string, string>>()
                .ConstructUsing((props, ctx) =>
                {
                    var properties = new Dictionary<string, string>();
                    foreach (var prop in props)
                    {
                        properties.Add(prop.Key, prop.Value);
                    }
                    return properties;
                });
            CreateMap<Client, ClientDto>()
                .ForMember(dto => dto.AllowedCorsOrigins, map => map.MapFrom(client => client.AllowedCorsOrigins.Select(origin => origin.Origin).ToList()))
                .ForMember(dto => dto.AllowedGrantTypes, map => map.MapFrom(client => client.AllowedGrantTypes.Select(grantType => grantType.GrantType).ToList()))
                .ForMember(dto => dto.AllowedScopes, map => map.MapFrom(client => client.AllowedScopes.Select(scope => scope.Scope).ToList()))
                .ForMember(dto => dto.IdentityProviderRestrictions, map => map.MapFrom(client => client.IdentityProviderRestrictions.Select(provider => provider.Provider).ToList()))
                .ForMember(dto => dto.PostLogoutRedirectUris, map => map.MapFrom(client => client.PostLogoutRedirectUris.Select(uri => uri.PostLogoutRedirectUri).ToList()))
                .ForMember(dto => dto.RedirectUris, map => map.MapFrom(client => client.RedirectUris.Select(uri => uri.RedirectUri).ToList()));

            //TODO:该类在v4.1版本已不存在
            //CreateMap<Volo.Abp.IdentityServer.ApiResources.ApiSecret, ApiSecretDto>();

            CreateMap<ApiScope, ApiScopeDto>();
            CreateMap<ApiResource, ApiResourceDto>()
                .ForMember(dto => dto.UserClaims, map => map.MapFrom(src => src.UserClaims.Select(claim => claim.Type).ToList()))
                .MapExtraProperties();

            CreateMap<IdentityResource, IdentityResourceDto>()
                .ForMember(dto => dto.UserClaims, map => map.MapFrom(src => src.UserClaims.Select(claim => claim.Type).ToList()))
                .MapExtraProperties();
        }
    }
}
