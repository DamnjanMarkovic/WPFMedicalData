using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Xml.Serialization;
using WPFMedicalDataGrid.Controls;
using WPFMedicalDataGrid.Model;
using Media = System.Windows.Media;

namespace WPFMedicalDataGrid.Helpers
{
    public static class StaticProperties
    {
        public readonly static string ConfigurationGUIStyle = "ConfigurationGUIStyle.xml";
        public readonly static string MedicalXMLFile = "MedicalData.xml";

        public static void SetCommonStyle(object fromObject, object toObject)
        {
            PropertyInfo[] toObjectProperties = toObject.GetType().GetProperties();
            foreach (PropertyInfo propTo in toObjectProperties)
            {
                PropertyInfo propFrom = fromObject.GetType().GetProperty(propTo.Name);
                if (propFrom != null && propFrom.CanWrite)
                    propTo.SetValue(toObject, propFrom.GetValue(fromObject, null), null);
            }
        }

        public static CustomStyle.CustomCommonStyle GetCommonValues(CustomStyle.CustomCommonProperties ControlWithStringProperties)
        {
            CustomStyle.CustomCommonStyle ControlWithValues = new CustomStyle.CustomCommonStyle();
            if ((ControlWithStringProperties == null)) return default(CustomStyle.CustomCommonStyle);

            try
            {
                ControlWithValues.Background = PropertiesConverter.GetSolidColorBrush(ControlWithStringProperties.Background);
                ControlWithValues.BorderBrush = PropertiesConverter.GetSolidColorBrush(ControlWithStringProperties.BorderBrush);
                ControlWithValues.Foreground = PropertiesConverter.GetSolidColorBrush(ControlWithStringProperties.Foreground);

                ControlWithValues.BackgroundMouseOver = PropertiesConverter.GetSolidColorBrush(ControlWithStringProperties.BackgroundMouseOver);
                ControlWithValues.BorderColorMouseOver = PropertiesConverter.GetSolidColorBrush(ControlWithStringProperties.BorderColorMouseOver);
                ControlWithValues.TextColorMouseOver = PropertiesConverter.GetSolidColorBrush(ControlWithStringProperties.TextColorMouseOver);

                ControlWithValues.BackgroundDisabled = PropertiesConverter.GetSolidColorBrush(ControlWithStringProperties.BackgroundDisabled);
                ControlWithValues.BorderColorDisabled = PropertiesConverter.GetSolidColorBrush(ControlWithStringProperties.BorderColorDisabled);
                ControlWithValues.TextColorDisabled = PropertiesConverter.GetSolidColorBrush(ControlWithStringProperties.TextColorDisabled);

                ControlWithValues.BackgroundChecked = PropertiesConverter.GetSolidColorBrush(ControlWithStringProperties.BackgroundChecked);
                ControlWithValues.BorderColorChecked = PropertiesConverter.GetSolidColorBrush(ControlWithStringProperties.BorderColorChecked);
                ControlWithValues.TextColorChecked = PropertiesConverter.GetSolidColorBrush(ControlWithStringProperties.TextColorChecked);

                ControlWithValues.CornerRadius = PropertiesConverter.GetCornerRadiusValue(ControlWithStringProperties.CornerRadius);
                ControlWithValues.BorderThickness = PropertiesConverter.GetBorderThickness(ControlWithStringProperties.BorderThickness);

                ControlWithValues.DropShadowEffectBlur = PropertiesConverter.GetValueDouble(ControlWithStringProperties.DropShadowEffectBlur);
                ControlWithValues.DropShadowEffectOpacity = PropertiesConverter.GetValueDouble(ControlWithStringProperties.DropShadowEffectOpacity);
                ControlWithValues.DropShadowEffectColor = PropertiesConverter.GetColor(ControlWithStringProperties.DropShadowEffectColor);
                ControlWithValues.DropShadowEffectShadowDepth = PropertiesConverter.GetValueDouble(ControlWithStringProperties.DropShadowEffectShadowDepth);

            }
            catch (Exception ex)
            {
                MessageBox.Show("something is wrong");
            }
            return ControlWithValues;
        }


        public static T DeserializeXMLFileToObject<T>(string XmlFilename)
        {
            T returnObject = default(T);
            if (string.IsNullOrEmpty(XmlFilename)) return default(T);

            try
            {
                StreamReader xmlStream = new StreamReader(XmlFilename);
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                returnObject = (T)serializer.Deserialize(xmlStream);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Styling from XML file has not been imported");
            }
            return returnObject;
        }


        public static T GetChildOfType<T>(this DependencyObject depObj)
            where T : DependencyObject
        {
            if (depObj == null) return null;

            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(depObj); i++)
            {
                var child = VisualTreeHelper.GetChild(depObj, i);

                var result = (child as T) ?? GetChildOfType<T>(child);
                if (result != null) return result;
            }
            return null;
        }

        public static MedicalDataList Load(string xmlPath)
        {
            return (MedicalDataList)Deserialize<MedicalDataList>(xmlPath);
        }


        public static T Deserialize<T>(string filename)
        {
            if (filename == null)
            {
                filename = StaticProperties.MedicalXMLFile;
            }
            try
            {
                T obj;

                FileStream fs = new FileStream(filename, FileMode.Open);

                XmlSerializer xs = new XmlSerializer(typeof(T));
                obj = (T)xs.Deserialize(fs);
                fs.Flush();
                fs.Close();

                return obj;
            }
            catch (System.IO.FileNotFoundException fnf)
            {
            }
            catch (Exception ex)
            {
            }


            return default(T);
        }
        public static bool Save(string filename, MedicalDataList obj)
        {
            return Serialize(filename, obj);
        }

        public static bool Serialize<T>(string filename, T obj)
        {
            try
            {
                if (filename == null)
                {
                    filename = StaticProperties.MedicalXMLFile;
                }
                if (File.Exists(filename))
                {
                    File.Delete(filename);
                }
                using (FileStream fs = new FileStream(filename, FileMode.CreateNew))
                {
                    XmlSerializer xs = new XmlSerializer(typeof(T));

                    xs.Serialize(fs, obj);
                    fs.Close();

                }
                return true;

            }
            catch (System.IO.FileNotFoundException fnf)
            {
            }
            catch (Exception ex)
            {
            }
            return false;
        }

        public static System.Windows.Controls.Image ColorBitmapSourceIntoMediaColor(BitmapSource bitmapSource, Media.Color markColor)
        {
            int stride = (bitmapSource.PixelWidth * bitmapSource.Format.BitsPerPixel + 7) / 8;

            int length = stride * bitmapSource.PixelHeight;
            byte[] data = new byte[length];

            bitmapSource.CopyPixels(data, stride, 0);

            //normal
            for (int i = 0; i < length; i += 4)
            {
                if (data[i + 3] == 0) continue;
                data[i] = (byte)(GetHexFromMediaColor(markColor).red); //B
                data[i + 1] = (byte)(GetHexFromMediaColor(markColor).green); //G
                data[i + 2] = (byte)(GetHexFromMediaColor(markColor).blue); //R

            }

            // Create a new BitmapSource from the inverted pixel buffer

            return new System.Windows.Controls.Image
            {
                Source = BitmapSource.Create(
                     bitmapSource.PixelWidth, bitmapSource.PixelHeight,
                     bitmapSource.DpiX, bitmapSource.DpiY, bitmapSource.Format,
                     bitmapSource.Palette, data, stride)
            };


        }
        public static RGBColors GetHexFromMediaColor(Media.Color color)
        {
            var resultAsHex = String.Format("#{0}{1}{2}{3}"
                , color.A.ToString("X").Length == 1 ? String.Format("0{0}", color.A.ToString("X")) : color.A.ToString("X")
                , color.R.ToString("X").Length == 1 ? String.Format("0{0}", color.R.ToString("X")) : color.R.ToString("X")
                , color.G.ToString("X").Length == 1 ? String.Format("0{0}", color.G.ToString("X")) : color.G.ToString("X")
                , color.B.ToString("X").Length == 1 ? String.Format("0{0}", color.B.ToString("X")) : color.B.ToString("X"));

            System.Drawing.Color colorFinal = System.Drawing.ColorTranslator.FromHtml(resultAsHex);
            int r = Convert.ToInt16(colorFinal.R);
            int g = Convert.ToInt16(colorFinal.G);
            int b = Convert.ToInt16(colorFinal.B);

            return new RGBColors(r, g, b);
        }

        public static DropShadowEffect SetDropShadowEffect(System.Windows.Media.Color DropShadowEffectColorArrived)
        {
            DropShadowEffect myDropShadowEffectMouseOver = new DropShadowEffect();
            myDropShadowEffectMouseOver.Opacity = 1;
            myDropShadowEffectMouseOver.Color = DropShadowEffectColorArrived;
            myDropShadowEffectMouseOver.ShadowDepth = 0;
            myDropShadowEffectMouseOver.BlurRadius = 15;
            return myDropShadowEffectMouseOver;
        }

    }
    public class RGBColors
    {
        public int red { get; set; }
        public int green { get; set; }
        public int blue { get; set; }
        public RGBColors(int r, int g, int b)
        {
            this.red = b;
            this.green = g;
            this.blue = r;
        }
    }
}
