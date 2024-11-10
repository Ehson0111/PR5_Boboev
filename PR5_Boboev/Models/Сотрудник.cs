//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PR5_Boboev.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Сотрудник
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Сотрудник()
        {
            this.Заявка = new HashSet<Заявка>();
            this.Отчетности = new HashSet<Отчетности>();
        }
    
        public int Id_Сотрудник { get; set; }
        public string Фамилия { get; set; }
        public string Имя { get; set; }
        public string Отчество { get; set; }
        public Nullable<decimal> Зарплата { get; set; }
        public string Пол { get; set; }
        public string Дата_рождение { get; set; }
        public string Контактные_данные { get; set; }
        public string паспортные_данные { get; set; }
        public string Должность { get; set; }
        public Nullable<int> id_Авторизация { get; set; }
    
        public virtual Авторизация Авторизация { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Заявка> Заявка { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Отчетности> Отчетности { get; set; }
    }
}
