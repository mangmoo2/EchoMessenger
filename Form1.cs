using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Echo_Messenger
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)  
        {
            string typed_msg = textBox1.Text.Trim();   // text박스에 입력된 변수 담고 _ 앞뒤 공백 제거
            if (!string.IsNullOrWhiteSpace(textBox1.Text)) // 공백 검사  //과제2
            {
                string time = DateTime.Now.ToString("[HH:mm:ss]"); // 메시지 앞에 현재시간 ([hh:mm:ss]) 을 자동으로 결합하여 리스트에 출력
                
                typed_msg = textBox1.Text;
                listBox1.Items.Add($"{time} {typed_msg}"); // 리스트 박스의 아이템 목록에 추가하기 + time 시간 정보 출력
            }
            textBox1.Clear();  // 텍스트 박스 내용 삭제    //과제2
            textBox1.Focus(); // 입력창에 입력 포커스 갖다 놓기   //과제2
            label2.Text = $"현재 대화: {listBox1.Items.Count}개"; //현재 리스트에쌓인 총메시지개수를 계산하여 하단 Label에 실시간으로업데이트
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
            if (e.KeyCode == Keys.Enter)     // enter키를 누르면   //과제2
            {
                button1_Click(sender, e);  // 전송 버튼 클릭을 메서드로 호출 
            }
        }
    }
}
