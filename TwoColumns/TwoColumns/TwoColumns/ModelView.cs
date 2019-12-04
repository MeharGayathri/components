using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace TwoColumns
{
    public class ModelView
    {
        public ObservableCollection<ClassTuple > AllModels { get; set; }
        public ObservableCollection<Images> fewModels { get; set; }
        public ModelView()
        {
            AllModels = new ObservableCollection<ClassTuple>();
            fewModels = new ObservableCollection<Images>();
            Images i1 = new Images("saujfghsjh");
            Images i2 = new Images("r");
            Images i3 = new Images("t");
            Images i4 = new Images("d");
            Images i5 = new Images("sf");
            Images i6 = new Images("dgtk");
            AllModels.Add(new ClassTuple { image1 = i1, image2 = i2 });
            AllModels.Add(new ClassTuple { image1 = i3, image2 = i4 });
            AllModels.Add(new ClassTuple { image1 = i5, image2 = i6 });
            fewModels.Add(i1);
            fewModels.Add(i2);
            fewModels.Add(i3);
            fewModels.Add(i4);
            fewModels.Add(i5);
            fewModels.Add(i6);

        }
    }
}
