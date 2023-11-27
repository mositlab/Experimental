# Experimental
Made for debugging code that requires visualization of 3D data

```C#
            // Для крафика
            GraphPane pane1 = zedGraphControl1.GraphPane;
            pane1.GraphObjList.Clear();
            pane1.CurveList.Clear();
            pane1.YAxis.Scale.FontSpec.Size = 10;

            PointPairList list1 = new PointPairList();
            list1.Add(x, y);

            // График
            pane1.AddCurve(sumDistance.ToString(), list1, Color.Blue, SymbolType.None);

            // Стрелки
            for (int i = 0; i < 100; i++)
            {
                double xend = x[i];
                double yend = y[i];

                double xstart = xend;
                double ystart = yend + 1;

                ArrowObj arrow = new ArrowObj(xstart, ystart, xend, yend);
                arrow.Line.Color = Color.Green;
                pane1.GraphObjList.Add(arrow);
                TextObj text = new TextObj("", xstart, ystart);
                text.FontSpec.Border.IsVisible = false;
                pane1.GraphObjList.Add(text);
            }
```

Код для добавления и вывода вокселей.

```C#
Pixel.Add(new CoordinatesType(x, y, z, size, new _PacketType(r, g, b)));
```
