/*
This is free and unencumbered software released into the public domain.

Anyone is free to copy, modify, publish, use, compile, sell, or
distribute this software, either in source code form or as a compiled
binary, for any purpose, commercial or non-commercial, and by any
means.

In jurisdictions that recognize copyright laws, the author or authors
of this software dedicate any and all copyright interest in the
software to the public domain. We make this dedication for the benefit
of the public at large and to the detriment of our heirs and
successors. We intend this dedication to be an overt act of
relinquishment in perpetuity of all present and future rights to this
software under copyright law.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
IN NO EVENT SHALL THE AUTHORS BE LIABLE FOR ANY CLAIM, DAMAGES OR
OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
OTHER DEALINGS IN THE SOFTWARE.
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CyrillicConverter
{
  public partial class MainForm : Form
  {
    private List<string> _encodings = new List<string>(10);

    public MainForm()
    {
      InitializeComponent();
    }

    private string[] ConvertEncoding(string[] inputLines, Encoding source, Encoding target)
    {
      string[] outputLines = new string[inputLines.Length];

      for (int i = 0; i < inputLines.Length; ++i)
      {
        byte[] rawBytes = source.GetBytes(inputLines[i]);
        string line = target.GetString(rawBytes);
        outputLines[i] = line;
      }

      return outputLines;
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void btnConvert_Click(object sender, EventArgs e)
    {
      Encoding sourceEncoding = Encoding.GetEncoding((string)cbSourceFormat.SelectedItem);
      Encoding resultEncoding = Encoding.GetEncoding((string)cbResultFormat.SelectedItem);

      tbTextResult.Lines = ConvertEncoding(tbTextSource.Lines, sourceEncoding, resultEncoding);
    }

    private void btnSwapText_Click(object sender, EventArgs e)
    {
      string sourceText = tbTextSource.Text;
      tbTextSource.Text = tbTextResult.Text;
      tbTextResult.Text = sourceText;

      int sourceIndex = cbSourceFormat.SelectedIndex;
      cbSourceFormat.SelectedIndex = cbResultFormat.SelectedIndex;
      cbResultFormat.SelectedIndex = sourceIndex;
    }

    private void FillEncodingsList()
    {
      _encodings.Add("utf-8");
      _encodings.Add("IBM855");
      _encodings.Add("windows-1251");
      _encodings.Add("windows-1252");
      _encodings.Add("cp866");
      _encodings.Add("x-mac-cyrillic");
      _encodings.Add("koi8-r");
      _encodings.Add("IBM880");
      _encodings.Add("koi8-u");
      _encodings.Add("iso-8859-5");
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
      FillEncodingsList();

      cbSourceFormat.Items.AddRange(_encodings.ToArray());
      cbResultFormat.Items.AddRange(_encodings.ToArray());

      cbSourceFormat.SelectedIndex = 0;
      cbResultFormat.SelectedIndex = 3;
    }

    private void ProcessHotkeys(object sender, KeyEventArgs e)
    {
      //NOTE(adm244): workaround for ctrl+a disabled on multiline textbox controls
      if (e.Control && e.KeyCode == Keys.A)
      {
        if (sender is TextBox)
        {
          (sender as TextBox).SelectAll();
        }
      }
    }

    private void tbTextSource_KeyDown(object sender, KeyEventArgs e)
    {
      ProcessHotkeys(sender, e);
    }

    private void tbTextResult_KeyDown(object sender, KeyEventArgs e)
    {
      ProcessHotkeys(sender, e);
    }
  }
}
