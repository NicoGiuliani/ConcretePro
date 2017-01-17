using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Concrete_Pro
{
  public partial class frmConcrete : Form
  {
    double dblHeight;
    double dblWidth;
    double dblDepth;
    double dblVolume;
    double dblTax = 1.092;
    string strCustomerName = "";
    string strCustomerAddress = "";
    string strCustomerCity = "";
    string strCustomerState = "";
    string strCustomerZip = "";
    string strColor;
    bool blnColorAdded = false;


    public frmConcrete()
    {
      InitializeComponent();
    }


    /********** FUNCTION **********/

    private void validateCustomerInfo()
    {
      if (strCustomerName != "" &&
          strCustomerAddress != "" &&
          strCustomerCity != "" &&
          strCustomerState != "" &&
          strCustomerZip != "")
      {
        grpDimensions.Enabled = true;
      }
      else
      {
        grpDimensions.Enabled = false;
      }
    }


    /********** CUSTOMER INFO **********/

    private void txtName_TextChanged(object sender, EventArgs e)
    {
      strCustomerName = txtName.Text;
      validateCustomerInfo();
    }

    private void txtAddress_TextChanged(object sender, EventArgs e)
    {
      strCustomerAddress = txtAddress.Text;
      validateCustomerInfo();
    }

    private void txtCity_TextChanged(object sender, EventArgs e)
    {
      strCustomerCity = txtCity.Text;
      validateCustomerInfo();
    }

    private void cmbState_SelectedIndexChanged(object sender, EventArgs e)
    {
      strCustomerState = cmbState.SelectedItem.ToString();
      validateCustomerInfo();
    }

    private void txtZip_TextChanged(object sender, EventArgs e)
    {
      strCustomerZip = txtZip.Text;
      validateCustomerInfo();
    }


    /********** DIMENSIONS **********/

    private void txtHeight_TextChanged(object sender, EventArgs e)
    {
      int x;
      if (int.TryParse(txtHeight.Text, out x))
      {
        if (txtHeight.Text.Length > 0)
        {
          dblHeight = double.Parse(txtHeight.Text);
        }
        else
        {
          dblHeight = 0;
        }
      }
      else
      {
        dblHeight = 0;
      }
    }

    private void txtWidth_TextChanged(object sender, EventArgs e)
    {
      int x;
      if (int.TryParse(txtWidth.Text, out x))
      {
        if (txtWidth.Text.Length > 0)
        {
          dblWidth = double.Parse(txtWidth.Text);
        }
        else
        {
          dblWidth = 0;
        }
      }
      else
      {
        dblWidth = 0;
      }
    }

    private void txtDepth_TextChanged(object sender, EventArgs e)
    {
      int x;
      if (int.TryParse(txtWidth.Text, out x))
      {
        if (txtDepth.Text.Length > 0)
        {
          dblDepth = double.Parse(txtDepth.Text);
        }
        else
        {
          dblDepth = 0;
        }
      }
      else
      {
        dblDepth = 0;
      }
    }


    /********** ADD COLOR **********/

    private void chkColor_CheckedChanged(object sender, EventArgs e)
    {
      if (chkColor.Checked)
      {
        blnColorAdded = true;
        txtColor.Enabled = true;
      }
      else
      {
        blnColorAdded = false;
        txtColor.Enabled = false;
      }
    }

    private void txtColor_TextChanged(object sender, EventArgs e)
    {
      strColor = txtColor.Text;
    }


    /********** RADIO BUTTONS **********/

    private void radPrivate_CheckedChanged(object sender, EventArgs e)
    {
      dblTax = 1.092;
    }

    private void radCommercial_CheckedChanged(object sender, EventArgs e)
    {
      dblTax = 1.05 * 1.092;
    }

    private void btnCalculate_Click(object sender, EventArgs e)
    {
      dblVolume = dblHeight * dblWidth * dblDepth;
      lblVolume.Text = dblVolume.ToString() + " ft³";

      if (blnColorAdded)
      {
        lblCost.Text = (((dblVolume * 2.5) + (dblVolume * 0.2)) * dblTax).ToString("c2");
      }
      else
      {
        lblCost.Text = ((dblVolume * 2.5) * dblTax).ToString("c2");
      }
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
      txtName.Text = "";
      txtAddress.Text = "";
      txtCity.Text = "";
      cmbState.Text = "";
      txtZip.Text = "";
      txtHeight.Text = "";
      txtWidth.Text = "";
      txtDepth.Text = "";
      txtColor.Text = "";
      chkColor.Checked = false;
      radPrivate.Checked = true;
      lblVolume.Text = "";
      lblCost.Text = "";

    }

    private void btnExit_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }


  }
}
