using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MitechCenter.vn.Models
{
    public class Partners
    {
        public Partners(string _logo, string _link)
        {
            this.logo = _logo;
            this.link = _link;
        }
        public string logo { get; set; }
        public string link { get; set; }

        public static List<Partners> fetchAll() {
            List<Partners> partners = new List<Partners>();
            partners.Add(new Partners("https://mitechcenter.vn/default/images/DT4.jpg","_________________"));
            partners.Add(new Partners("https://mitechcenter.vn/default/images/DT1.jpg","_________________"));
            partners.Add(new Partners("https://mitechcenter.vn/default/images/DT2.jpg","_________________"));
            partners.Add(new Partners("https://mitechcenter.vn/default/images/DT3.jpg","_________________"));
            partners.Add(new Partners("https://mitechcenter.vn/default/images/DT4.jpg","_________________"));
            partners.Add(new Partners("https://avalonsolution.asia/themes/AvalonSolution/images/client-2.png","_________________"));
            partners.Add(new Partners("https://avalonsolution.asia/themes/AvalonSolution/images/client-3.png","_________________"));
            partners.Add(new Partners("https://avalonsolution.asia/themes/AvalonSolution/images/client-4.png","_________________"));
            partners.Add(new Partners("https://avalonsolution.asia/themes/AvalonSolution/images/client-5.png","_________________"));
            partners.Add(new Partners("https://avalonsolution.asia/themes/AvalonSolution/images/client-6.png","_________________"));
            partners.Add(new Partners("https://avalonsolution.asia/themes/AvalonSolution/images/client-7.png","_________________"));
            partners.Add(new Partners("https://avalonsolution.asia/themes/AvalonSolution/images/client-8.png","_________________"));
            partners.Add(new Partners("https://avalonsolution.asia/themes/AvalonSolution/images/client-9.png","_________________"));
            partners.Add(new Partners("https://avalonsolution.asia/themes/AvalonSolution/images/client-10.png","_________________"));
            partners.Add(new Partners("https://avalonsolution.asia/themes/AvalonSolution/images/client-11.png","_________________"));
            partners.Add(new Partners("https://avalonsolution.asia/themes/AvalonSolution/images/client-12.png","_________________"));
            partners.Add(new Partners("https://avalonsolution.asia/themes/AvalonSolution/images/client-1.png","_________________"));
            return partners;
        }
    }
}
