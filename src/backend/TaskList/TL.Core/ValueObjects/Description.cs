using TL.Core.Common;
using TL.Core.Common.Exceptions;
using TL.Core.Entities;
using TL.Core.Entities.Application;

namespace TL.Core.ValueObjects
{
    /// <summary>
    /// Отформатированное описание
    /// </summary>
    public class Description : AuditableEntity<int>
    {
        /// <summary>
        /// Разметка
        /// </summary>
        public string Marking { get; private set; }

        /// <summary>
        /// Ссылки на изображения
        /// </summary>
        public List<string> Images { get; private set; } = new List<string>();

        public Description(string text)
        {
            SetMarking(text);
        }

        public void SetMarking(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                throw new DomainException($"Описание не может быть пустым");
            }

            Marking = text;
        }

        public void SetImages(string text)
        {
            // Добавить извлечение картинок из разметки
        }
    }
}
