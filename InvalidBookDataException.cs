class InvalidBookDataException : LibraryException
{
    public InvalidBookDataException() : base() { }

    public InvalidBookDataException(string message) : base(message) { }
}