namespace ArxUtils
{
	public class Singleton<T> where T : new()
	{
		public static T Instance => Inner.InnerInstance;
		private Singleton() { }

		private class Inner
		{
			internal static T InnerInstance = new T();
			static Inner() { }
		}
	}
}
