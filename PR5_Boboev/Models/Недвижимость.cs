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
    
    public partial class Недвижимость
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Недвижимость()
        {
            this.Заявка = new HashSet<Заявка>();
        }
    
        public int Id_Недвижимости { get; set; }
        public int Id_Клиент { get; set; }
        public string Стоимость { get; set; }
        public string Адресс { get; set; }
        public string Этаж { get; set; }
        public string Номер_квартиры { get; set; }
        public string C_Тип_недвижимости { get; set; }
        public string Общая_площадь { get; set; }
        public string Тип_жилья { get; set; }
        public string Высота_потолков { get; set; }
        public string Вид_из_окна { get; set; }
        public string Количество_ливтов { get; set; }
        public int Год_сдачи { get; set; }
        public string Парковка { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Заявка> Заявка { get; set; }
        public virtual Собственник Собственник { get; set; }
    }
}
