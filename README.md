# Rki.CancerDataGenerator
Generator for German Clinical Cancer Data<br>
# Documentation
swagger.authentification.jwt.code analyzer

## packages

## startup

code:<br>    
  ```csharp
        /// <summary>
        /// get random enum
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T FetchRandomEnumItem<T>(double missingProb = 0) where T : Enum
        {
            var list = fetchAllEnumItems<T>();
            var itemNone = fetchNoneEnumItem(list);
            // handle missingProb
            if (_random.NextDouble() < missingProb)
                return fetchNoneEnumItem(list);     // warning: if no item "none" is present, this will return enum[0]

            if (itemNone?.ToString() == "None")
                list.Remove(itemNone);
            return list[_random.Next(list.Count)];
        }

  ```

[![Readme Card](https://github-readme-stats.vercel.app/api/pin/?username=smeisegeier&repo=VsCode)](https://github.com/anuraghazra/github-readme-stats)
<br>
[![smeisegeier's GitHub stats](https://github-readme-stats.vercel.app/api?username=smeisegeier&count_private=true&hide_border=true&show_icons=true)](https://github.com/anuraghazra/github-readme-stats)
<br>


You can render UML diagrams using [Mermaid](https://mermaidjs.github.io/). For example, this will produce a sequence diagram:

```mermaid
sequenceDiagram
Alice ->> Bob: Hello Bob, how are you?
Bob-->>John: How about you John?
Bob--x Alice: I am good thanks!
Bob-x John: I am good thanks!
Note right of John: Bob thinks a long<br/>long time, so long<br/>that the text does<br/>not fit on a row.

Bob-->Alice: Checking with John...
Alice->John: Yes... John, how are you?
```

And this will produce a flow chart:

```mermaid
graph LR
A[Square Rect] -- Link text --> B((Circle))
A --> C(Round Rect)
B --> D{Rhombus}
C --> D
```
