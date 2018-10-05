using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LearningASP.NET_MVC_V0._0._2.Models
{
    public class Album // We create Album class inside Model, so we can use it later in viewbag(?)
    {
        public string Artist { get; set; }
        public string AlbumName { get; set; }
    }
}