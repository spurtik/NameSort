using System.Collections.Generic;


namespace NameSorter.Helpers
{
    public interface IFileHelper<TMapper>
    {
        string TargetPathRead 
        { 
            get; 
            set; 
        }
        string TargetPathWrite 
        { 
            get; 
            set; 
        }
        List<TMapper> ReadFile();
        void WriteFile(List<TMapper> objects);
    }
}