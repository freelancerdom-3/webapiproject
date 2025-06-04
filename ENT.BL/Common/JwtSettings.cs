using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT.BL.Common
{
    public static class JwtSettings
    {
        public static string jwtKey = "9uMvWdM+0TzO7U9f7y/2G1n5V3dU4rO4g7nPtqElxZJnOHbN2o0Q3ZIb2WXnQk6B";

        public static string issuer = "Sahaayak-OnlineServices.com";

        public static string audience = "Users";

        public static string subject = "Admin/EndUser/ServiceProvider";

        public static int expiryMinutes = 240;
    }
}
