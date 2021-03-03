using System;
using System.Collections;
using UsingLibrary;

namespace ExampleEnumerable.IEnumerableObjects
{
	class EnumeratorTransport : IEnumerator
	{
		Transport[] _transport;
		int _position;
		object IEnumerator.Current
		{
			get
			{
				return Current;
			}
		}
		Transport Current
		{
			get
			{
				try
				{
					return _transport[_position];
				}
				catch (IndexOutOfRangeException)
				{
					throw new InvalidCastException();
				}
			}
		}

		public EnumeratorTransport(Transport[] transports)
		{
			_position = transports.Length;
			_transport = transports;
		}

		public void Reset()
		{
			_position = _transport.Length;
		}

		public bool MoveNext()
		{
			_position--;
			return (_position != -1);
		}
	}
}
