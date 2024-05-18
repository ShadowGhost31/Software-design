using System.Diagnostics.Tracing;
using System.Text;

namespace LightHTMLSharp.Models
{
    public class LightElementNode : LightNode
    {
        public string TagName { get; }
        public string DisplayType { get; }
        public string ClosingType { get; }
        public List<string> CssClasses { get; }
        public List<LightNode> ChildNodes { get; }
        private List<EventListener> eventListeners = new List<EventListener>();

        public LightElementNode(string tagName, string displayType, string closingType, List<string> cssClasses, List<LightNode> childNodes)
        {
            TagName = tagName;
            DisplayType = displayType;
            ClosingType = closingType;
            CssClasses = cssClasses;
            ChildNodes = childNodes;
        }

        public override string OuterHTML
        {
            get
            {
                StringBuilder htmlBuilder = new StringBuilder();
                htmlBuilder.Append($"<{TagName}");

                // Додавання класів CSS
                if (CssClasses != null && CssClasses.Count > 0)
                {
                    htmlBuilder.Append(" class=\"");
                    htmlBuilder.Append(string.Join(" ", CssClasses));
                    htmlBuilder.Append("\"");
                }

                htmlBuilder.Append(">");

                // Додавання внутрішніх елементів
                foreach (var childNode in ChildNodes)
                {
                    htmlBuilder.Append(childNode.OuterHTML);
                }

                // Закриваючий тег
                if (ClosingType == "dual")
                {
                    htmlBuilder.Append($"</{TagName}>");
                }
                else if (ClosingType == "single")
                {
                    htmlBuilder.Append(" /");
                }

                return htmlBuilder.ToString();
            }
        }

        public override string InnerHTML
        {
            get
            {
                StringBuilder htmlBuilder = new StringBuilder();

                foreach (var childNode in ChildNodes)
                {
                    htmlBuilder.Append(childNode.OuterHTML);
                }

                return htmlBuilder.ToString();
            }
        }

        public void AddEventListener(string eventType, Action handler)
        {
            eventListeners.Add(new EventListener(eventType, handler));
        }

        public void TriggerEvent(string eventType)
        {
            foreach (var listener in eventListeners)
            {
                if (listener.EventType == eventType)
                {
                    listener.HandleEvent();
                }
            }
        }
    }
}
