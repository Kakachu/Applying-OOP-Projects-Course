using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.ValueObjects
{
	public class Social : ValueObjects
	{
        public Social(UserName userName)
        {
            UserName = userName;

            InvalidSocialException.ThrowIfInvalid(userName);
        }

        public UserName UserName { get; set; }
    }
}
