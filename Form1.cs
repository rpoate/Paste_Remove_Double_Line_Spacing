using System.Diagnostics;

namespace Paste_RemoveCrLF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.htmlEditControl1.CSSText = "body {font-family: arial} div>p {margin-top: 1pt; margin-bottom: 1pt}";
        }

        private void htmlEditControl1_CancellableUserInteraction(object sender, Zoople.CancellableUserInteractionEventsArgs e)
        {
            if (e.InteractionType == Zoople.EditorUIEvents.onbeforepaste)
            {
                if (Clipboard.ContainsText(TextDataFormat.Html))
                {
                    Debug.WriteLine(Clipboard.GetText(TextDataFormat.Html));
                    HtmlElement oDiv = this.htmlEditControl1.InsertHTMLELement("div");
                    this.htmlEditControl1.MoveCursorToElement(oDiv, Zoople.HTMLEditControl._ELEM_ADJACENCY.ELEM_ADJ_AfterBegin);
                }
            }
        }
    }
}
