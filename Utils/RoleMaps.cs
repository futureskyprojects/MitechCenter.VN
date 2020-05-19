using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MitechCenter.vn.Utils
{
    public class RoleMaps
    {
        public RoleMaps(int code, string name)
        {
            this.role = code;
            this.name = name;
        }
        public int role { get; set; }
        public string name { get; set; }

        public static RoleMaps[] getAll()
        {
            return new[]{
                new RoleMaps(0,"Quản trị hệ thống"),
                new RoleMaps(1,"Quản trị nội dung"),
                new RoleMaps(2,"Quản trị khóa học"),
                new RoleMaps(3,"Không cấp quyền")
            };
        }

        public static SelectList getSelectList()
        {
            return new SelectList(getAll(), "role", "name");
        }

        public static string getRoleName(int code)
        {
            foreach (RoleMaps roleMaps in getAll())
            {
                if (roleMaps.role == code)
                    return roleMaps.name;
            }
            return getAll().Last().name;
        }
    }
}
