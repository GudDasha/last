//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Мероприятия1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Активности
    {
        public int Индекс { get; set; }
        public int Код_мероприятия { get; set; }
        public string Активность { get; set; }
        public int День { get; set; }
        public string Время_начала { get; set; }
        public int код_модератора { get; set; }
        public Nullable<int> код_жюри1 { get; set; }
        public Nullable<int> код_жюри2 { get; set; }
        public Nullable<int> код_жюри3 { get; set; }
        public Nullable<int> код_жюри4 { get; set; }
        public Nullable<int> код_жюри5 { get; set; }
        public Nullable<int> код_победителя { get; set; }
    
        public virtual Мероприятия Мероприятия { get; set; }
        public virtual Пользователи Пользователи { get; set; }
        public virtual Пользователи Пользователи1 { get; set; }
        public virtual Пользователи Пользователи2 { get; set; }
        public virtual Пользователи Пользователи3 { get; set; }
        public virtual Пользователи Пользователи4 { get; set; }
        public virtual Пользователи Пользователи5 { get; set; }
        public virtual Пользователи Пользователи6 { get; set; }
    }
}
