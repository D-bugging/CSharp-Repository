Func (System) representa um método que recebe zero ou maius argumentos, e retorna um valor
Existem 16 variações do Action.

public delegate TResult Func<out TResult>();
public delegate TResult Func<in T, out TResult>(T obj);
public delegate void Func<in T1, in T2, out TResult>(T1 arg1, T2 arg2);
public delegate void Func<in T1, in T2, in T3, out TResult>(T1 arg1, T2 arg2, arg3);