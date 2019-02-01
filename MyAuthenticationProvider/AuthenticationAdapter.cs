using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityServer.Web.Authentication.External;

namespace MyAuthenticationProvider
{

    //https://blogs.technet.microsoft.com/cloudpfe/2014/02/01/how-to-create-a-custom-authentication-provider-for-active-directory-federation-services-on-windows-server-2012-r2-part-2/
    //https://docs.microsoft.com/en-us/windows-server/identity/ad-fs/deployment/install-the-ad-fs-role-service

    class AuthenticationAdapter : IAuthenticationAdapter
    {
        public IAuthenticationAdapterMetadata Metadata => throw new NotImplementedException();

        public IAdapterPresentation BeginAuthentication(Claim identityClaim, HttpListenerRequest request, IAuthenticationContext context)
        {
            throw new NotImplementedException();
        }

        public bool IsAvailableForUser(Claim identityClaim, IAuthenticationContext context)
        {
            throw new NotImplementedException();
        }

        public void OnAuthenticationPipelineLoad(IAuthenticationMethodConfigData configData)
        {
            throw new NotImplementedException();
        }

        public void OnAuthenticationPipelineUnload()
        {
            throw new NotImplementedException();
        }

        public IAdapterPresentation OnError(HttpListenerRequest request, ExternalAuthenticationException ex)
        {
            throw new NotImplementedException();
        }

        public IAdapterPresentation TryEndAuthentication(IAuthenticationContext context, IProofData proofData, HttpListenerRequest request, out Claim[] claims)
        {
            throw new NotImplementedException();
        }
    }
}
