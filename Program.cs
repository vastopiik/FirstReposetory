using HW13;


Student s = new Student();

Action<string, int> action = s.A1;
action += s.A2;
action += s.A3;

Func<int, double, string> func = s.F1;
func += s.F2;
func += s.F3;

Predicate<int> predicate = s.P1;
predicate += s.P2;
predicate += s.P3;





bool b = true;
int n = b.ToInt();

string date = "12,5,2003";
DateTime dateTime = date.ToDate();

double d = 4.6;
int n2 = d.ToInt();

