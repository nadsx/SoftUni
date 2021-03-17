ИЗПИТНА ЗАДАЧА 3:
Library

1) ПАПКА MODELS

		public int Id { get; set; }

		[Required]
		public string Title { get; set; }

		[Required]
		public string Author { get; set; }

		public decimal Price { get; set; } = 1;


2) След това създаване на папка Data, в която създаваме ИМЕDBContext(LibraryDbContext) 
класа и вътре в нея връзката с БАЗАТА ДАННИ.  

	public class LibraryDbContext : DbContext
	{
		public DbSet<Book> Books { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=LibraryDb;Trusted_Connection=True");
		}
	}

3)
Следваща стъпка конфигуриране на МИГРАЦИЯТА.
В търсачката отгоре в дясно напиши "console".
-1"Add-Migration initial"
-2"Update-Database"
В MICROSOFT SQL Server Management Studio натисни connect и 
там автоматично се появява базите данни.

4) FINAL CONTROLLER

   public class LibraryController : Controller
    {
        public IActionResult Index()
        {
            using(var db = new LibraryDbContext())
			{
				List<Book> books = db.Books.ToList();

				return View(books);
			}
        }

        [HttpGet]
        public IActionResult Create()
        {
			return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
			if(string.IsNullOrEmpty(book.Title) || string.IsNullOrEmpty(book.Author))
			{
				return RedirectToAction("Create");
			}

            using(var db = new LibraryDbContext())
			{
				db.Books.Add(book);
				db.SaveChanges();
			}

			return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            using(var db = new LibraryDbContext())
			{
				Book book = db.Books.Find(id); //.FirstOrDefault(x => x.Id == id)

				return View(book);
			}
            
        }

        [HttpPost]
        public IActionResult Edit(Book book)
        {
            using(var db = new LibraryDbContext())
			{
				db.Books.Update(book);
				db.SaveChanges();
			}

			return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            using(var db = new LibraryDbContext())
			{
				Book book = db.Books.Find(id);
				return View(book);
			}
        }

        [HttpPost]
        public IActionResult Delete(Book book)
        {
            using(var db = new LibraryDbContext())
			{
				db.Books.Remove(book);
				db.SaveChanges();
			}

			return RedirectToAction("Index");
        }
    }


===============================================

ИЗПИТНА ЗАДАЧА 3:
TeisterMask

1) ПАПКА MODELS

		public int Id { get; set; }

		[Required]
		public string Title { get; set; }

		[Required]
		public string Status { get; set; }


2) След това създаване на папка Data, в която създаваме ИМЕDBContext(LibraryDbContext) 
класа и вътре в нея връзката с БАЗАТА ДАННИ.  

	public class TeisterMaskDbContext : DbContext
	{
		public DbSet<Task> Tasks { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=MeisterTaskDb;Integrated Security=True;");
		}
	}

3)
Следваща стъпка конфигуриране на МИГРАЦИЯТА.
В търсачката отгоре в дясно напиши "console".
-1"Add-Migration initial"
-2"Update-Database"
В MICROSOFT SQL Server Management Studio натисни connect и 
там автоматично се появява базите данни.

4) FINAL CONTROLLER

    public class TaskController : Controller
    {
        public IActionResult Index()
        {
			using(var db = new TeisterMaskDbContext())
			{
				var tasks = db.Tasks.ToList();
				return View(tasks);
			}        
        }

		[HttpGet]
		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Create(string title, string status)
		{
			if(string.IsNullOrEmpty(title))
			{
				return RedirectToAction("Index");
			}		

			using(var db = new TeisterMaskDbContext())
			{
				Task task = new Task
				{
					Title = title,
					Status = status			
				};

				db.Tasks.Add(task);
				db.SaveChanges();			
			}

			return RedirectToAction("Index");
		}

		[HttpGet]
		public IActionResult Edit(int id)
		{
			using (var db = new TeisterMaskDbContext())
			{
				var taskToEdit = db.Tasks.Find(id);

				return View(taskToEdit);
			}
		}

		[HttpPost]
		public IActionResult Edit(Task task)
		{
			using(var db = new TeisterMaskDbContext())
			{
				db.Tasks.Update(task);
				db.SaveChanges();
			}

			return RedirectToAction("Index");
		}

		[HttpGet]
		public IActionResult Delete(int id)
		{
			using (var db = new TeisterMaskDbContext())
			{
				var taskToDelete = db.Tasks.Find(id);

				return View(taskToDelete);
			}
		}

		[HttpPost]
		public IActionResult Delete(Task task)
		{
			using (var db = new TeisterMaskDbContext())
			{
				db.Tasks.Remove(task);
				db.SaveChanges();
			}

			return RedirectToAction("Index");
		}
	}

===============================================

ИЗПИТНА ЗАДАЧА 3:
ToDoList

1) ПАПКА MODELS

		public int Id { get; set; }

		[Required]
		public string Title { get; set; }

		[Required]
		public string Comments { get; set; }


2) След това създаване на папка Data, в която създаваме ИМЕDBContext(LibraryDbContext) 
класа и вътре в нея връзката с БАЗАТА ДАННИ.  

	public class ToDoDbContext: DbContext
	{
		private const string ConnectionString = @"Server=.\SQLEXPRESS;Database=ToDoList;Integrated Security=true;";
		public virtual DbSet<Task> Tasks { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(ConnectionString);
		}
	}

3)
Следваща стъпка конфигуриране на МИГРАЦИЯТА.
В търсачката отгоре в дясно напиши "console".
-1"Add-Migration initial"
-2"Update-Database"
В MICROSOFT SQL Server Management Studio натисни connect и 
там автоматично се появява базите данни.

4) FINAL CONTROLLER

    public class TaskController : Controller
    {
        public IActionResult Index()
        {
			using (var db = new ToDoDbContext())
			{
				List<Task> tasks = db.Tasks.ToList();

				return View(tasks);
			}
        }

		[HttpGet]
		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Create(string title, string comments)
		{
			if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(comments))
			{
				return RedirectToAction("Index");
			}

			Task newTask = new Task
			{
				Title = title,
				Comments = comments,
			};

			using(var db = new ToDoDbContext())
			{
				db.Tasks.Add(newTask);
				db.SaveChanges();
			}

			return RedirectToAction("Index");
		}

		[HttpGet]
		public IActionResult Edit(int id)
		{
			using (var db = new ToDoDbContext())
			{
				var oldTask = db.Tasks.FirstOrDefault(x => x.Id == id);

				if(oldTask == null)
				{
					return RedirectToAction("Index");
				}

				return View(oldTask);
			}
		}

		[HttpPost]
		public IActionResult Edit(Task newTask)
		{
			if (!ModelState.IsValid)
			{
				return RedirectToAction("Index");
			}

			using (var db = new ToDoDbContext())
			{
				var oldTask = db.Tasks.FirstOrDefault(x => x.Id == newTask.Id);

				if (oldTask == null)
				{
					return RedirectToAction("Index");
				}

				oldTask.Title = newTask.Title;
				oldTask.Comments = newTask.Comments;
				db.SaveChanges();

				return RedirectToAction("Index");
			}
		}

		public IActionResult Details(int id)
		{
			using (var db = new ToDoDbContext())
			{
				var oldTask = db.Tasks.FirstOrDefault(x => x.Id == id);

				if (oldTask == null)
				{
					return RedirectToAction("Index");
				}

				return View(oldTask);
			}
		}

		public IActionResult Delete(int id)
		{
			using (var db = new ToDoDbContext())
			{
				var task = db.Tasks.FirstOrDefault(x => x.Id == id);

				if (task == null)
				{
					return RedirectToAction("Index");
				}

				db.Tasks.Remove(task);
				db.SaveChanges();

				return RedirectToAction("Index");
			}
		}