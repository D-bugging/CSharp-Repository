File e FileInfo são duas classes para utilizar arquivos.

Namespace System.IO
using System.IO;
IOException

* File
    - static members (simples, mas realiza verificação de segurança para cada operação)
    - um pouco mais lenta que a FileInfo
    - para programa simples

* FileInfo
    - instance members
    - programa fica um pouco mais rápido pois não precisa realizar verificação
    - para muitas operações e que a performance for importante

FileStream é um objeto que encapsula a escrita ou a leitura.