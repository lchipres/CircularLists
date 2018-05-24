using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularLists
{
    class DataStructure
    {
        Base first;
        int numberBase;
        
        public DataStructure()
        {
            first = null;
            numberBase = 0;
        }

        public void AddFinal(Base b)
        {
            if (EmptyList())
            {
                AddFirst(b);
            }
            else
            {
                Add(first,b);
            }
        }

        private void Add(Base place,Base b)
        {
            if (place.next == first)
            {
                b.next = first;
                place.next =b;
                numberBase++;
            }
            else
            {
                Add(place.next, b);
            }
        }

        private void AddFirst(Base b)
        {
            Base toAdd = new Base(b);//The new one 
            first=b;//Go for the first
            first.next=first;//Assign to first
            numberBase++;
        }

        public Base Search(string name)
        {
            Base b = null;//To save base found
            Base helper;//Help to success
            helper = first;

            do
            {
                if (helper.name == name)//Is the name im looking for?
                {
                    b = helper;//Yes give it to me
                    break;
                }
                helper = helper.next;//Go for the next one dude
            } while (helper.next!= first);
            if (helper.name == name)//Is the last?
                b = helper;
            return b;//Show me that
        }

        public Base DeleteLast()
        {
            Base helper;
            if (EmptyList())
            {
                return null;
            }
            else if (first.next == first)
            {
                helper = first;
                first = null;

                return helper;
            }
            else
            {
                return Delete(first);
            }

        }

        private Base Delete(Base b)
        {
            Base deleted = null;

            if (b.next.next == first)
            {
                deleted = b.next;//Before delete, know who is going to be deleted
                b.next = first;//New relationship <3
                numberBase--;

                return deleted;//Return who was your X
            }
            else
            {
                return Delete(b.next);
            }
        }

        public Base DeleteFirst()
        {
            Base deleted =first;

            while (deleted.next != first)
            {
                deleted = deleted.next;//Point to the end
            }

            deleted = deleted.next;//Who was
            first = first.next;//New relationship
            numberBase--;

            return deleted;
            }

        public Base DeleteByName(string name)
        {
            Base b = null;
            return b;
        }

        public string List()
        {
            string s = "";
            Base helper;
            helper = first;
            for(int i=0;i<numberBase;i++)
            {
                s += helper.ToString()+Environment.NewLine;
                helper = helper.next;
            }
            return s;
        }

        public void Insert(Base b, Int32 pos)
        {
            Base helper = first,helper2;

            if (pos > numberBase || EmptyList())
            {

            }
            else if (pos==1)
            {
                while (helper.next != first)//Pointing to last
                {
                    helper = helper.next;
                }
                b.next = helper.next;//Next of new is first
                helper = b;//Previous is the new
            }
            else
            {
                for (int i = 1; i < pos-2; i++)
                {
                    helper = helper.next;
                }
                helper2 = helper.next;//Previous of the pos
                helper.next = b;//Previous is next
                b.next = helper2;//Next of new is previous
            }
            
        }

        public string Route(string _name, DateTime _hourBegin, DateTime _hourEnd)
        {
            string s = "";
            Base helper = first;
            while (helper.name != _name)
            {
                helper = helper.next;
            }
            for(;_hourBegin<=_hourEnd ; )
            {
                s += helper.ToString()+Environment.NewLine;
                _hourBegin=_hourBegin.AddMinutes(Convert.ToDouble(helper.minutes));
                helper=helper.next;
            }
            return s;
        }

        public bool EmptyList()
        {
            bool flag=true;
            if (first != null)
                flag = false;
            return flag;
        }
    }
}
