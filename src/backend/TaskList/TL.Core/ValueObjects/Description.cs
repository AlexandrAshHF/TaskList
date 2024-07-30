using TL.Core.Common.Entity;
using TL.Core.Common.Exceptions;
using TL.Core.Common.ValueObject;

namespace TL.Core.ValueObjects
{
    /// <summary>
    /// Отформатированное описание
    /// </summary>
    public class Description : BaseObject
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

        public Description()
        {
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

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Marking;
            yield return Images;
        }
    }
}
