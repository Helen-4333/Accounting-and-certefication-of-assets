//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Assets
{
    using System;
    using System.Collections.Generic;
    
    public partial class Service
    {
        public int id { get; set; }
        public int id_request { get; set; }
        public string title { get; set; }
        public string vid_service { get; set; }
        public string type_service { get; set; }
        public string status { get; set; }
    
        public virtual Request Request { get; set; }
    }
}