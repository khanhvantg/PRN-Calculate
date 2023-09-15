# PRN-Calculate
Một biểu thức gồm các token như:\
  –	Ký tự (,)\
  –	Toán tử: +, -, *, /,\
  –	Toán hạng: số thực, biến\
Thuật toán chuyển đổi biểu thức trung tố sang hậu tố: nhóm chúng em sẽ sử dụng cây biểu thức (expression tree) để giải quyết\
Thuật toán này yêu cầu sử dụng 2 stack:\
  – OperatorStack: chứa các toán tử\
  – NodeStack: chứa các node tạo nên cấu trúc cây (node gốc của các cây con được xây dựng từ dưới lên)\
Lặp qua từng token trong biểu thức trung tố\
  – Nếu là toán hạng: push vào NodeStack\
  – Nếu là dấu mở ngoặc “(“: push vào OperatorStack\
  – Nếu là dấu đóng ngoặc “)”:\
    +	Lặp cho đến khi lấy được dấu mở ngoặc “(“ trong OperatorStack\
    +	Pop dấu mở ngoặc ra khỏi OperatorStack.\
  – Nếu là toán tử:\
    +	Lặp cho đến khi OperatorStack rỗng hoặc độ ưu tiên của toán tử ở đỉnh OperatorStack nhỏ hơn độ ưu tiên của toán tử hiện tại.\
    +	Push toán tử vào OperatorStack.\
Toán tử cuối cùng nằm trong NodeStack là node gốc của cây.\
Sau khi thực hiện thuật toán trên, ta sẽ duyệt cây theo Post-Order thì sẽ tạo nên chuỗi PostFix

Duới đây là mô tả thuật toán:\
  – Ví dụ ta có biểu thức: a+b-(c+d*e-g)-f/h\
  – Ta tiến hành duyệt biểu thức từ trái sang phải\
<img src="https://user-images.githubusercontent.com/92866486/268369489-a36754f8-e565-4ffd-8d46-c55dcd1a51a3.png"/>
  – Duyệt cây nhị phân:\
<img src="https://user-images.githubusercontent.com/92866486/268371641-9e00ac28-e1b5-4309-9ade-685058e47a51.png"/>
Demo thực tế:\
<img src="https://user-images.githubusercontent.com/92866486/268369496-b163f249-dbc5-4818-93f7-507d4a44fd31.png"/>
