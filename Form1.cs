using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Поле
{
	public partial class Form1 : Form
	{
		bool isMoving, bStop;
		List<int> UsedValue;
		public Form1()
		{
			InitializeComponent();
			RedPlayer.BackColor  = Color.Transparent;
			RedPlayer.MouseDown += this.SMouseDown;
			RedPlayer.MouseUp	+= this.SMouseUp;
			RedPlayer.MouseMove += this.RedMouseMove;
			
			YellowPlayer.BackColor   = Color.Transparent;
			YellowPlayer.MouseDown	+= this.SMouseDown;
			YellowPlayer.MouseUp	+= this.SMouseUp;
			YellowPlayer.MouseMove	+= this.YellowMouseMove;
			
			GreenPlayer.BackColor    = Color.Transparent;
			GreenPlayer.MouseDown	+= this.SMouseDown;
			GreenPlayer.MouseUp		+= this.SMouseUp;
			GreenPlayer.MouseMove	+= this.GreenMouseMove;
			
			BluePlayer.BackColor     = Color.Transparent;
			BluePlayer.MouseDown	+= this.SMouseDown;
			BluePlayer.MouseUp		+= this.SMouseUp;
			BluePlayer.MouseMove	+= this.BlueMouseMove;

			this.DoubleBuffered = true;

			label2.Text = "60";
			UsedValue = new List<int>();
		}
		private void SMouseDown(object sender, MouseEventArgs e)
		{
			isMoving = true;
		}
		private void SMouseUp(object sender, MouseEventArgs e)
		{
			isMoving = false;
		}

		private void BlueMouseMove(object sender, MouseEventArgs e)
		{
			if (isMoving) //изменяем координаты текущего PictureBox
			{
				int CurrentTruePosX = System.Windows.Forms.Cursor.Position.X - this.Location.X - 15;
				int CurrentTruePosY = System.Windows.Forms.Cursor.Position.Y - this.Location.Y - 40;

				BluePlayer.Location = new Point(CurrentTruePosX, CurrentTruePosY);
			}
		}
		private void YellowMouseMove(object sender, MouseEventArgs e)
		{
			if (isMoving) //изменяем координаты текущего PictureBox
			{
				int CurrentTruePosX = System.Windows.Forms.Cursor.Position.X - this.Location.X - 15;
				int CurrentTruePosY = System.Windows.Forms.Cursor.Position.Y - this.Location.Y - 40;

				YellowPlayer.Location = new Point(CurrentTruePosX, CurrentTruePosY);
			}
		}
		private void GreenMouseMove(object sender, MouseEventArgs e)
		{
			if (isMoving) //изменяем координаты текущего PictureBox
			{
				int CurrentTruePosX = System.Windows.Forms.Cursor.Position.X - this.Location.X - 15;
				int CurrentTruePosY = System.Windows.Forms.Cursor.Position.Y - this.Location.Y - 40;

				GreenPlayer.Location = new Point(CurrentTruePosX, CurrentTruePosY);
			}
		}
		private void RedMouseMove(object sender, MouseEventArgs e)
		{
			if (isMoving) //изменяем координаты текущего PictureBox
			{
				int CurrentTruePosX = System.Windows.Forms.Cursor.Position.X - this.Location.X - 15;
				int CurrentTruePosY = System.Windows.Forms.Cursor.Position.Y - this.Location.Y - 40;

				RedPlayer.Location = new Point(CurrentTruePosX, CurrentTruePosY);
			}
		}

		// Проверка на уникальность
		private bool CheckValue(int val, int MaxCount)
		{
			if (UsedValue.Count == MaxCount)
			{
				UsedValue.Clear();
				return false;

			}
			foreach (var arg in UsedValue)
			{
				if (arg == val)
					return true;
			}

			UsedValue.Add(val);
			return false;
		}
		public void Thread()
		{
			int sSecond = DateTime.Now.Second;
			int sSecondOld = DateTime.Now.Second;
			int sMinutes = DateTime.Now.Minute + 1;

			while (!bStop)
			{
				if(sSecondOld < DateTime.Now.Second)
				{
					label2.Invoke(new Action(() => label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) - 1)));
					sSecondOld = DateTime.Now.Second;
				}

				if (sSecond == DateTime.Now.Second && sMinutes == DateTime.Now.Minute)
				{
					System.Media.SystemSounds.Exclamation.Play();
					MessageBox.Show("Stop!");
					break;
				}
			}

			label2.Invoke(new Action(() => label2.Text = "60"));
			bStop = false;
		}
		private void GetWords_Click(object sender, EventArgs e)
		{
			string Current = "";
			List<string> is1 = new List<string>
			{
				"Бежать, Думать", "Лежать, Прыгать", "Уснуть, Повиснуть", "Засунуть, Разносить", "Брить, Ходить", "Лизнуть, Ложить",
				"Повиснуть, Падать", "Дышать, Летать", "Лаять, Нюхать", "Петь, Думать", "Качать, Искать", "Учить, Писать",
				"Бежать, Плевать", "Умничать, Наказывать", "Угрожать, Шевелить", "Зависить, Ненавидить", "Терперь, Обидеть",
				"Считать, Просить", "Попрошайничать, Мыть", "Бить, Курить", "Отдыхать, Работать", "Уходить, Приглашать",
				"Впускать, Мечтать", "Изобретать, Проявлять", "Трещать, Разговаривать", "Играть, Хлопать", "Аплодировать, Агитировать",
				"Перевозить, Выступать", "Крутить, Тянуть", "Гладить, Умиляться", "Парить, Прощаться", "Плыть, Взлетать",
				"Мусорить, Злиться", "Кормить, Заботиться", "Строить, Крутить"
			};
			List<string> is2 = new List<string>
			{
				"Мыло, Чайка", "Аист, Клетка, Сом", "Стул, Доска, Окно","Пульт, Батарейки, Телевизор",
				"Кино, Кровь, Ход", "Удар, Конь, Ложка", "Спица, Акула, Солнце", "Шаг, Душ, Перо",
				"Хомяк, Клавиатура, Туз", "Козырь, Нос, Улитка", "Собака, Палка, Дуб", "Кольцо, Девочка, Рост",
				"Телефон, Бутылка, Тарелка", "Тетрадь, Банка, Книга", "Джостик, Лавочка", "Идея, Абзац, Цапля",
				"Удар, Сигарета, Мультфильм", "Отпуск, Работа, Билет", "Дорога, Шина, Игла",
				"Выпускной, Цветок, Пудра", "Звонок, Пена, Соль", "Хуй )0)0)), Пятно, Заяц", "Слон, Театр, Касса",
				"Мальчик, Игрушка, Юла", "Ребёнок, Урна, Полиция", "Авации, Стена", "Груз, Артист, Парусник", "Качели, Гамак, Вилы",
				"Банк, Вред, Человек", "Скряга, Терасса", "Такса, Кукушка, Столица", "Балкон, Критик, Действие", "Дротик, Поезд, Вокзал",
				"Давление, Стон, Кукуруза", "Пирамида, Кнопка, Лестница"
			};

			List<string> is5 = new List<string>
			{
				"Мягкий, Милый",			"Музыкальный, Солнечный",							"Скрытный, Страшный",
				"Стеклянный, Сложный",		"Мокрый, Косой",			"Синий, Деревянный",    "Деловой",
				"Тяжёлый, Громкий",			"Рукописный",				"Глухой, лёгкий",		"Простой, Ночной",
				"Серебренный, Ветренный",	"Холодный, Бархатный",		"Белый, Тусклый",		"Золотой, Клёвый",
				"Каменный, Ленивый",		"Водный, Квадратный",		"Дикий, Сладкий",		"Сахарный, Ручной",
				"Удачливый, Игровой",		"Званый, Тихий",			"Быстрый, Мёртвый",		"Медленный, Солёный",
				"Детский, Волосатый",		"Грязный, Правильный",		"Тёплый, Близкий",		"Плохой, Жадный",
				"Умный, Добрый",			"Сильный, Прямой",			"Параллельный",			"Мясной",
				"Спортивный, Сказочный",	"Пьяный, Маленький",		"Глупый, Толстый",		"Волосатый, Грозный"
			};

			List<string> is4 = new List<string>
			{
				"Бодуэн де Куртенэ", "Всеволод Третий Большое Гнездо", "Шар Де Голь", "ди-Витторио", "Гусь-Хрустальный","Дон-Жуан",
				"дон Педро", "Илья Муромец", "Леонардо да Винчи", "Буратино", "Гендальф", "Фроддо", "Карл Маркс",
				"Капитанская дочка", "Юлий Цезарь", "Аполон-12", "Альтаир", "Тонни Старк", "Шестой", "Ник Фьюри", "Тимати",
				"Егор Крид", "Филипп Киркоров", "Поздравляю, тебе повезло! Загадай что угодно!", "Зевс", "Станиславский"
			};

			List<string> is3 = new List<string>
			{
				"Альфа-лучи", "Белая Церковь", "Резус", "Левитация", "Валюта", "Текстура", "Бортмеханик", "Вакуум-сушилка",
				"Генерал-лейтенант", "Гоп-Компания",  "Дизель-Мотор" , "Кинооператор", "Донкихотство",  "Христианство", 
				"Зюйд-Вест", "Изба-Читальня", "Камера", "контр-адмирал", "контрнаступление",  "мать-и-мачеха", "Москва-Товарная",
				"Обер-мастер", "Поздравляю, тебе повезло! Загадай что угодно!", "Перекати-поле", "Пол-Аршина,", "Штурмовик",
				"Гермитизация", "Биллютень", "Донжуанство", "Ансамбль", "Лапти"
			};

			// Генерируем уникальный номер для 1, 2 и 5
			Random Rand = new Random();
			int value = Rand.Next(0, is1.Count - 1);
			while (CheckValue(value, is1.Count - 1))
			{
				value = Rand.Next(0, is1.Count - 1);
			};

			// Генерируем сообщение
			Current += "1: " + is1[value] + "\n";
			Current += "2: " + is2[value] + "\n";
			Current += "3: " + is3[Rand.Next(0, is3.Count - 1)] + "\n";
			Current += "4: " + is4[Rand.Next(0, is4.Count - 1)] + "\n";
			Current += "5: " + is5[value] + "\n";
			if (MessageBox.Show(Current, "Задание!") == DialogResult.OK)
			{
        		System.Threading.Thread myThread = new System.Threading.Thread(new System.Threading.ThreadStart(Thread));
        		myThread.Start(); // запускаем поток
			}
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			bStop = true;
		}
	}
}