LINQ - Language Integrated Query

Namespace System.Linq

* É um conjunto de tecnologias baseadas na integração de funcionalidades de consulta diretamente na linguagem c#.
	- Operações chamadas diretamente a partir das coleções.
	- Consultas são objetos de primeira classe
	- Suporte do compilador e IntelliSense da IDE

* Operações do LINQ
	- Filtering: Where, OfType
	- Sorting: OrderBy, OrderByDescending, ThenBy, ThenbyDescending, Reverse
	- Set: Distinct, Except, Intersect, Union
	- Quantification: All, Any, Contains
	- Projection: Select, SelectMany
	- Partition: Skip, Take
	- Join: Join, GroupJoin
	- Grouping: GroupBy
	- Generational: Empty
	- Equality: SequenceEquals
	- Element: ElementAt, First, FirstOrDefault, Last, LastOrDefault, Single, SingleOrDefault
	- Conversions: AsEnurable, AsQueryable
	- Concatenation: Concat
	- Aggregation: Aggregate, Average, Count, LongCount, Max, Min, Sum