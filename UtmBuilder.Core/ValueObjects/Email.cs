using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.ValueObjects
{
	public class Email : ValueObjects
	{
        public Email(string address)
        {
            Address = address;
            InvalidEmailException.ThrowIfInvalid(address);
        }

        public string Address { get; private set; }
    }
}
