Action (System) representa um método void que recebe zero ou mais argumentos.

Existem 16 variações do Action.

public delegate void Action();
public delegate void Action<in T>(T obj);
public delegate void Action<in T1, in T2>(T1 arg1, T2 arg2);
public delegate void Action<in T1, in T2, in T3>(T1 arg1, T2 arg2, arg3);
