namespace FilaPoc
{
	public interface IFila<T>
	{
		public void Enfilerar(T item);

		public T Desenfilerar();
	}
}