using System.Collections.Generic;

#region Класс на основе коллекции Stack.
public class UndoRedoStack<T>
{
	Stack<ICommand<T>> _undo;
	Stack<ICommand<T>> _redo;
	public UndoRedoStack ()
	{
		_undo = new Stack<ICommand<T>>();
		_redo = new Stack<ICommand<T>>();
	}

	public void Reset ()    //Метод, обнуляющий содержимое UndoRedoStack.
	{
		_undo = new Stack<ICommand<T>>();
		_redo = new Stack<ICommand<T>>();
	}

	#region Реализация "погружения и добычи" данных в памяти программы.

	public T Do (ICommand<T> cmd, T input)
	{
		T output = cmd.Do(input);
		_undo.Push(cmd);
		_redo.Clear();
		return output;
	}

	public T Undo (T input)
	{
		if (_undo.Count > 0)
		{
			ICommand<T> cmd = _undo.Pop();
			T output = cmd.Undo(input);
			_redo.Push(cmd);
			return output;
		}
		else
			return input;
	}

	public T Redo (T input)
	{
		if (_redo.Count > 0)
		{
			ICommand<T> cmd = _redo.Pop();
			T output = cmd.Do(input);
			_undo.Push(cmd);
			return output;
		}
		else
			return input;
	}
	#endregion
}
#endregion