Console.Clear(); // Очищает консоль
//Console.SetCursorPosition (10,4); // позволяет "рисовать", ставит курсос на позицию(10 от левого края, 4 от верхнего края)
//Console.Write ("+");

int xa=40;
int ya=1;
int xb=1;
int yb=30;
int xc=90, yc=30;
Console.SetCursorPosition (xa,ya);
Console.Write ("+");
Console.SetCursorPosition (xb,yb);
Console.Write ("+");
Console.SetCursorPosition (xc,yc);
Console.Write ("+");
int x=xa, y=xb;

int count=0;
while (count<20000)
{
    int what=new Random().Next(0,3); // генерируем случайное число между нашими вершинами [0.3)полуинтервал для наших вершин, 0,1,2
    if(what==0)
    {
        x=(x+xa)/2;
        y=(y+ya)/2;
    }
    if(what==1)
    {
        x=(x+xb)/2;
        y=(y+yb)/2;
    }
    if(what==2)
    {
        x=(x+xc)/2;
        y=(y+yc)/2;
    }
    Console.SetCursorPosition (x,y);
    Console.Write ("+");
    count=count+1;
    } // можно записывать так count+=1 или count++