ال struct زيه زي ال class بس value type  
زي  كده  
struct Point
{
    public int X;
    public int Y;
}

---
الـ Record بيستخدم لما اكون عايزة اخزن بيانات 

record Student(int Id, string Name); 

---

ال indexer 

هي بتخلي الـ Object يتعامل كأنه Array.
student[0]; <<<<<