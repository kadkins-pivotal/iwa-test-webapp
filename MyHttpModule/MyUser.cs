using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace MyHttpModule
{
    public class MyUser : System.Security.Principal.GenericPrincipal
    {
        public MyUser(IIdentity identity, string[] roles) : base(identity, roles)
        {
        }

        public override IEnumerable<Claim> Claims => base.Claims;

        public override IEnumerable<ClaimsIdentity> Identities => base.Identities;

        public override IIdentity Identity => base.Identity;

        protected override byte[] CustomSerializationData => base.CustomSerializationData;

        public override void AddIdentities(IEnumerable<ClaimsIdentity> identities)
        {
            base.AddIdentities(identities);
        }

        public override void AddIdentity(ClaimsIdentity identity)
        {
            base.AddIdentity(identity);
        }

        public override ClaimsPrincipal Clone()
        {
            return base.Clone();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override IEnumerable<Claim> FindAll(Predicate<Claim> match)
        {
            return base.FindAll(match);
        }

        public override IEnumerable<Claim> FindAll(string type)
        {
            return base.FindAll(type);
        }

        public override Claim FindFirst(Predicate<Claim> match)
        {
            return base.FindFirst(match);
        }

        public override Claim FindFirst(string type)
        {
            return base.FindFirst(type);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool HasClaim(Predicate<Claim> match)
        {
            return base.HasClaim(match);
        }

        public override bool HasClaim(string type, string value)
        {
            return base.HasClaim(type, value);
        }

        public override bool IsInRole(string role)
        {
            return base.IsInRole(role);
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override void WriteTo(BinaryWriter writer)
        {
            base.WriteTo(writer);
        }

        protected override ClaimsIdentity CreateClaimsIdentity(BinaryReader reader)
        {
            return base.CreateClaimsIdentity(reader);
        }

        protected override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
        }

        protected override void WriteTo(BinaryWriter writer, byte[] userData)
        {
            base.WriteTo(writer, userData);
        }
    }
}
