namespace E_Voter.Domain.Exceptions;

public class TokenExpiredException : Exception
{
    public TokenExpiredException() : base("Token has expired") { }
    public TokenExpiredException(string message) : base(message) { }
}