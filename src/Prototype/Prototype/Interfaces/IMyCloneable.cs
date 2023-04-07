namespace Prototype.Interfaces
{
    public interface IMyCloneable<out T>
    {
        public T MyClone();
    }
}
