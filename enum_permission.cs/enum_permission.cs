using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment4
{
    internal class enum_permission
    {
        enum Permissions
        {
            None = 0,
            Read = 1 << 0,  // 1
            Write = 1 << 1, // 2
            Execute = 1 << 2 // 4
        }

        public class enum_permissions
        {
            public static void main(string[] args)
            {
                Permissions userPermissions = Permissions.Read | Permissions.Write; // User has both read and write permissions

                // Check if a user has specific permissions
                if (userPermissions.HasFlag(Permissions.Read))
                {
                    Console.WriteLine("User has read permission.");
                }

                if (userPermissions.HasFlag(Permissions.Write))
                {
                    Console.WriteLine("User has write permission.");
                }

                if (userPermissions.HasFlag(Permissions.Execute))
                {
                    Console.WriteLine("User has execute permission.");
                }
                else
                {
                    Console.WriteLine("User does not have execute permission.");
                }
            }
        }
    }
}

