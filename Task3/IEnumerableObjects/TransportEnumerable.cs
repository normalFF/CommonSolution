using System;
using System.Collections;
using UsingLibrary;

namespace Task3.IEnumerableObjects
{
	class TransportEnumerable : IEnumerable
	{
		Transport[] _transports;

		public TransportEnumerable(Transport[] transport)
		{
			_transports = new Transport[transport.Length];

			for (int i = 0; i < _transports.Length; i++)
			{
				_transports[i] = transport[i];
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		IEnumerator GetEnumerator()
		{
			return new EnumeratorTransport(_transports);
		}
	}
}
