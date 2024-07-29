using TL.Core.Common;
using TL.Core.Entities.Empl;
using TL.Core.Enums.Application;

namespace TL.Core.Entities.Application
{
    /// <summary>
    /// Отношение сотрудника в заявлении
    /// </summary>
    public class EmployeeInApplication : Entity<int>
    {
        /// <summary>
        /// Сотрудник
        /// </summary>
        public virtual Employee Employee { get; set; }
        public int EmployeeId { get; set; }

        /// <summary>
        /// Заявление
        /// </summary>
        public virtual TLApplication Application { get; set; }
        public int ApplicationId { get; set; }

        /// <summary>
        /// Статус сотрудника
        /// </summary>
        public EmplInAppStatus Status { get; set; }
    }
}
