List<string> TaskList =  new List<string>();

int menuSelected = 0;
do
{
    menuSelected = ShowMainMenu();
    if ((Menu)menuSelected == Menu.Add)
    {
        ShowMenuAdd();
    }
    else if ((Menu)menuSelected == Menu.Remove)
    {
        ShowMenuRemove();
    }
    else if ((Menu)menuSelected == Menu.List)
    {
        ShowMenuTaskList();
    }
} while ((Menu)menuSelected != Menu.Exit);

/// <summary>
/// Show the options for Task, 1. Nueva tarea, 2. Remover tarea, 3. Tareas pendientes
/// </summary>
/// <returns>Returns option indicated by user</returns>
static int ShowMainMenu()
{
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("Ingrese la opción a realizar: ");
    Console.WriteLine("1. Nueva tarea");
    Console.WriteLine("2. Remover tarea");
    Console.WriteLine("3. Tareas pendientes");
    Console.WriteLine("4. Salir");

    string line = Console.ReadLine();
    return Convert.ToInt32(line);
}

void ShowMenuRemove()
{
    try
    {
        Console.WriteLine("Ingrese el número de la tarea a remover: ");
        ShowTaskList();

        string line = Console.ReadLine();
        int indexToRemove = Convert.ToInt32(line) - 1;

        if ((indexToRemove > TaskList.Count -1) || (indexToRemove > 0))
        {
            Console.WriteLine("Numero de tarea seleccionado no es valido");
        }
        else{
            if ((indexToRemove > -1) && (TaskList.Count > 0))
            {
                string task = TaskList[indexToRemove];
                TaskList.RemoveAt(indexToRemove);
                Console.WriteLine("Tarea " + task + " eliminada");
            }
        }
    }

    catch (Exception ex)
    {
        Console.WriteLine("Ha ocurrido un error al eliminar la tarea");
    }
}

void ShowMenuAdd()
{
    try
    {
        Console.WriteLine("Ingrese el nombre de la tarea: ");
        string task = Console.ReadLine();

        if(string.IsNullOrEmpty(task) == true)
        {
            Console.WriteLine("Las tareas no pueden tener campos vacíos");
        }
        else{
            TaskList.Add(task);
            Console.WriteLine("Tarea registrada");

        }


    }
    catch (Exception ex)
    {
        Console.WriteLine("Ha ocurrido un error al registrar la tarea");
    }
}

void ShowMenuTaskList()
{
    if (TaskList?.Count > 0)
    {
        ShowTaskList();
    } 
    else
    {
        Console.WriteLine("No hay tareas por realizar");
    }
}

void ShowTaskList()
{
    Console.WriteLine("----------------------------------------");
    var indexTask = 1;
    TaskList.ForEach(task => Console.WriteLine($"{indexTask++} . {task}"));
    Console.WriteLine("----------------------------------------");
}

public enum Menu
{
    Add = 1,
    Remove = 2,
    List = 3,
    Exit = 4
}