using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Echo_Messenger
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)  // 공백 검사 
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                string typed_msg;  // text박스에 입력된 변수 담고
                typed_msg = textBox1.Text;
                listBox1.Items.Add(typed_msg); // 리스트 박스의 아이템 목록에 추가하기
            }
            textBox1.Clear();  // 텍스트 박스 내용 삭제 
            textBox1.Focus(); // 입력창에 입력 포커스 갖다 놓기
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)     // enter키를 누르면 
            {
                button1_Click(sender, e);  // 전송 버튼 클릭을 메서드로 호출 
            }
        }
    }
}
