public interface ICommand<T>
{
	T Do (T input);
	T Undo (T input);
}

#region Класс для обмена данными с Generic коллекцией Stack.
public class AddIntCommand : ICommand<int>
{
	public AddIntCommand (int value) => Value = value;
	public AddIntCommand () { }
	public int Value { get; set; }
	public int Do (int input) => input + Value;
	public int Undo (int input) => input - Value;
}
#endregion