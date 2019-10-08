using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bmarcotte2c1
{
    public partial class Form1 : Form
    {
        private byte byte1, byte2, byte3;
        private sbyte sbyte1, sbyte2, sbyte3;
        private short short1, short2, short3;
        private ushort ushort1, ushort2, ushort3;
        private int int1, int2, int3;
        private uint uint1, uint2, uint3;
        private long long1, long2, long3;
        private ulong ulong1, ulong2, ulong3;
        private float float1, float2, float3;
        private double double1, double2, double3;
        private decimal decimal1, decimal2, decimal3;

        private void MulButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.byte3 = Convert.ToByte(this.byte1 * this.byte2);
                Byte3TextBox.Text = byte3.ToString();
            }
            catch (Exception) { Byte3TextBox.Text = "error"; }
            try
            {
                this.sbyte3 = Convert.ToSByte(this.sbyte1 * this.sbyte2);
                Sbyte3TextBox.Text = sbyte3.ToString();
            }
            catch (Exception) { Sbyte3TextBox.Text = "error"; }
            try
            {
                this.short3 = Convert.ToInt16(this.short1 * this.short2);
                Short3TextBox.Text = short3.ToString();
            }
            catch (Exception) { Short3TextBox.Text = "error"; }
            try
            {
                this.ushort3 = Convert.ToUInt16(this.ushort1 * this.ushort2);
                Ushort3TextBox.Text = ushort3.ToString();
            }
            catch (Exception) { Ushort3TextBox.Text = "error"; }
            try
            {
                this.int3 = checked(this.int1 * this.int2);
                Int3TextBox.Text = int3.ToString();
            }
            catch (Exception) { Int3TextBox.Text = "error"; }
            try
            {
                this.uint3 = checked(this.uint1 * this.uint2);
                Uint3TextBox.Text = uint3.ToString();
            }
            catch (Exception) { Uint3TextBox.Text = "error"; }
            try
            {
                this.long3 = checked(this.long1 * this.long2);
                Long3TextBox.Text = long3.ToString();
            }
            catch (Exception) { Long3TextBox.Text = "error"; }
            try
            {
                this.ulong3 = checked(this.ulong1 * this.ulong2);
                Ulong3TextBox.Text = ulong3.ToString();
            }
            catch (Exception) { Ulong3TextBox.Text = "error"; }
            try
            {
                this.float3 = checked(this.float1 * this.float2);
                Float3TextBox.Text = float3.ToString();
            }
            catch (Exception) { Float3TextBox.Text = "error"; }
            try
            {
                this.double3 = checked(this.double1 * this.double2);
                Double3TextBox.Text = double3.ToString();
            }
            catch (Exception) { Double3TextBox.Text = "error"; }
            try
            {
                this.decimal3 = checked(this.decimal1 * this.decimal2);
                Decimal3TextBox.Text = decimal3.ToString();
            }
            catch (Exception) { Decimal3TextBox.Text = "error"; }
        }

        private void DivButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.byte3 = Convert.ToByte(this.byte1 / this.byte2);
                Byte3TextBox.Text = byte3.ToString();
            }
            catch (Exception) { Byte3TextBox.Text = "error"; }
            try
            {
                this.sbyte3 = Convert.ToSByte(this.sbyte1 / this.sbyte2);
                Sbyte3TextBox.Text = sbyte3.ToString();
            }
            catch (Exception) { Sbyte3TextBox.Text = "error"; }
            try
            {
                this.short3 = Convert.ToInt16(this.short1 / this.short2);
                Short3TextBox.Text = short3.ToString();
            }
            catch (Exception) { Short3TextBox.Text = "error"; }
            try
            {
                this.ushort3 = Convert.ToUInt16(this.ushort1 / this.ushort2);
                Ushort3TextBox.Text = ushort3.ToString();
            }
            catch (Exception) { Ushort3TextBox.Text = "error"; }
            try
            {
                this.int3 = checked(this.int1 / this.int2);
                Int3TextBox.Text = int3.ToString();
            }
            catch (Exception) { Int3TextBox.Text = "error"; }
            try
            {
                this.uint3 = checked(this.uint1 / this.uint2);
                Uint3TextBox.Text = uint3.ToString();
            }
            catch (Exception) { Uint3TextBox.Text = "error"; }
            try
            {
                this.long3 = checked(this.long1 / this.long2);
                Long3TextBox.Text = long3.ToString();
            }
            catch (Exception) { Long3TextBox.Text = "error"; }
            try
            {
                this.ulong3 = checked(this.ulong1 / this.ulong2);
                Ulong3TextBox.Text = ulong3.ToString();
            }
            catch (Exception) { Ulong3TextBox.Text = "error"; }
            try
            {
                this.float3 = checked(this.float1 / this.float2);
                Float3TextBox.Text = float3.ToString();
            }
            catch (Exception) { Float3TextBox.Text = "error"; }
            try
            {
                this.double3 = checked(this.double1 / this.double2);
                Double3TextBox.Text = double3.ToString();
            }
            catch (Exception) { Double3TextBox.Text = "error"; }
            try
            {
                this.decimal3 = checked(this.decimal1 / this.decimal2);
                Decimal3TextBox.Text = decimal3.ToString();
            }
            catch (Exception) { Decimal3TextBox.Text = "error"; }
        }

        private void SubButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.byte3 = Convert.ToByte(this.byte1 - this.byte2);
                Byte3TextBox.Text = byte3.ToString();
            }
            catch (Exception) { Byte3TextBox.Text = "error"; }
            try
            {
                this.sbyte3 = Convert.ToSByte(this.sbyte1 - this.sbyte2);
                Sbyte3TextBox.Text = sbyte3.ToString();
            }
            catch (Exception) { Sbyte3TextBox.Text = "error"; }
            try
            {
                this.short3 = Convert.ToInt16(this.short1 - this.short2);
                Short3TextBox.Text = short3.ToString();
            }
            catch (Exception) { Short3TextBox.Text = "error"; }
            try
            {
                this.ushort3 = Convert.ToUInt16(this.ushort1 - this.ushort2);
                Ushort3TextBox.Text = ushort3.ToString();
            }
            catch (Exception) { Ushort3TextBox.Text = "error"; }
            try
            {
                this.int3 = checked(this.int1 - this.int2);
                Int3TextBox.Text = int3.ToString();
            }
            catch (Exception) { Int3TextBox.Text = "error"; }
            try
            {
                this.uint3 = checked(this.uint1 - this.uint2);
                Uint3TextBox.Text = uint3.ToString();
            }
            catch (Exception) { Uint3TextBox.Text = "error"; }
            try
            {
                this.long3 = checked(this.long1 - this.long2);
                Long3TextBox.Text = long3.ToString();
            }
            catch (Exception) { Long3TextBox.Text = "error"; }
            try
            {
                this.ulong3 = checked(this.ulong1 - this.ulong2);
                Ulong3TextBox.Text = ulong3.ToString();
            }
            catch (Exception) { Ulong3TextBox.Text = "error"; }
            try
            {
                this.float3 = checked(this.float1 - this.float2);
                Float3TextBox.Text = float3.ToString();
            }
            catch (Exception) { Float3TextBox.Text = "error"; }
            try
            {
                this.double3 = checked(this.double1 - this.double2);
                Double3TextBox.Text = double3.ToString();
            }
            catch (Exception) { Double3TextBox.Text = "error"; }
            try
            {
                this.decimal3 = checked(this.decimal1 - this.decimal2);
                Decimal3TextBox.Text = decimal3.ToString();
            }
            catch (Exception) { Decimal3TextBox.Text = "error"; }
        }

        private void Input2TextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                byte2 = Convert.ToByte(Input2TextBox.Text);
                Byte2TextBox.Text = byte2.ToString();
            }
            catch (Exception) { Byte2TextBox.Text = "error"; byte2 = 0; }
            try
            {
                sbyte2 = Convert.ToSByte(Input2TextBox.Text);
                Sbyte2TextBox.Text = sbyte2.ToString();
            }
            catch (Exception) { Sbyte2TextBox.Text = "error"; sbyte2 = 0; }
            try
            {
                short2 = Convert.ToInt16(Input2TextBox.Text);
                Short2TextBox.Text = short2.ToString();
            }
            catch (Exception) { Short2TextBox.Text = "error"; short2 = 0; }
            try
            {
                ushort2 = Convert.ToUInt16(Input2TextBox.Text);
                Ushort2TextBox.Text = ushort2.ToString();
            }
            catch (Exception) { Ushort2TextBox.Text = "error"; ushort2 = 0; }
            try
            {
                int2 = Convert.ToInt32(Input2TextBox.Text);
                Int2TextBox.Text = int2.ToString();
            }
            catch (Exception) { Int2TextBox.Text = "error"; int2 = 0; }
            try
            {
                uint2 = Convert.ToUInt32(Input2TextBox.Text);
                Uint2TextBox.Text = uint2.ToString();
            }
            catch (Exception) { Uint2TextBox.Text = "error"; uint2 = 0; }
            try
            {
                long2 = Convert.ToInt64(Input2TextBox.Text);
                Long2TextBox.Text = long2.ToString();
            }
            catch (Exception) { Long2TextBox.Text = "error"; long2 = 0; }
            try
            {
                ulong2 = Convert.ToUInt64(Input2TextBox.Text);
                Ulong2TextBox.Text = ulong2.ToString();
            }
            catch (Exception) { Ulong2TextBox.Text = "error"; ulong2 = 0; }
            try
            {
                float2 = Convert.ToSingle(Input2TextBox.Text);
                Float2TextBox.Text = float2.ToString();
            }
            catch (Exception) { Float2TextBox.Text = "error"; float2 = 0.0f; }
            try
            {
                double2 = Convert.ToDouble(Input2TextBox.Text);
                Double2TextBox.Text = double2.ToString();
            }
            catch (Exception) { Double2TextBox.Text = "error"; double2 = 0; }
            try
            {
                decimal2 = Convert.ToDecimal(Input2TextBox.Text);
                Decimal2TextBox.Text = decimal2.ToString();
            }
            catch (Exception) { Decimal2TextBox.Text = "error"; decimal2 = 0m; }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.byte3 = Convert.ToByte(this.byte1 + this.byte2);
                Byte3TextBox.Text = byte3.ToString();
            }
            catch (Exception) { Byte3TextBox.Text = "error";  }
            try
            {
                this.sbyte3 = Convert.ToSByte(this.sbyte1 + this.sbyte2);
                Sbyte3TextBox.Text = sbyte3.ToString();
            }
            catch (Exception) { Sbyte3TextBox.Text = "error"; }
            try
            {
                this.short3 = Convert.ToInt16(this.short1 + this.short2);
                Short3TextBox.Text = short3.ToString();
            }
            catch (Exception) { Short3TextBox.Text = "error"; }
            try
            {
                this.ushort3 = Convert.ToUInt16(this.ushort1 + this.ushort2);
                Ushort3TextBox.Text = ushort3.ToString();
            }
            catch (Exception) { Ushort3TextBox.Text = "error"; }
            try
            {
                this.int3 = checked(this.int1 + this.int2);
                Int3TextBox.Text = int3.ToString();
            }
            catch (Exception) { Int3TextBox.Text = "error"; }
            try
            {
                this.uint3 = checked(this.uint1 + this.uint2);
                Uint3TextBox.Text = uint3.ToString();
            }
            catch (Exception) { Uint3TextBox.Text = "error"; }
            try
            {
                this.long3 = checked(this.long1 + this.long2);
                Long3TextBox.Text = long3.ToString();
            }
            catch (Exception) { Long3TextBox.Text = "error"; }
            try
            {
                this.ulong3 = checked(this.ulong1 + this.ulong2);
                Ulong3TextBox.Text = ulong3.ToString();
            }
            catch (Exception) { Ulong3TextBox.Text = "error"; }
            try
            {
                this.float3 = checked(this.float1 + this.float2);
                Float3TextBox.Text = float3.ToString();
            }
            catch (Exception) { Float3TextBox.Text = "error"; }
            try
            {
                this.double3 = checked(this.double1 + this.double2);
                Double3TextBox.Text = double3.ToString();
            }
            catch (Exception) { Double3TextBox.Text = "error"; }
            try
            {
                this.decimal3 = checked(this.decimal1 + this.decimal2);
                Decimal3TextBox.Text = decimal3.ToString();
            }
            catch (Exception) { Decimal3TextBox.Text = "error"; }
        }

        

        public Form1()
        {
            InitializeComponent();
        }

        private void SetMinButton_Click(object sender, EventArgs e)
        {

            byte1 = Byte.MinValue; Byte1TextBox.Text = byte1.ToString();
            sbyte1 = SByte.MinValue; Sbyte1TextBox.Text = sbyte1.ToString();
            short1 = Int16.MinValue; Short1TextBox.Text = short1.ToString();
            ushort1 = UInt16.MinValue; Ushort1TextBox.Text = ushort1.ToString();
            int1 = Int32.MinValue; Int1TextBox.Text = int1.ToString();
            uint1 = UInt32.MinValue; Uint1TextBox.Text = uint1.ToString();
            long1 = Int64.MinValue; Long1TextBox.Text = long1.ToString();
            ulong1 = UInt64.MinValue; Ulong1TextBox.Text = ulong1.ToString();
            float1 = Single.MinValue; Float1TextBox.Text = float1.ToString();
            double1 = Double.MinValue; Double1TextBox.Text = double1.ToString();
            decimal1 = Decimal.MinValue; Decimal1TextBox.Text = decimal1.ToString();
        }

        private void SetMaxButton_Click(object sender, EventArgs e)
        {

            byte2 = Byte.MaxValue; Byte2TextBox.Text = byte2.ToString();
            sbyte2 = SByte.MaxValue; Sbyte2TextBox.Text = sbyte2.ToString();
            short2 = Int16.MaxValue; Short2TextBox.Text = short2.ToString();
            ushort2 = UInt16.MaxValue; Ushort2TextBox.Text = ushort2.ToString();
            int2 = Int32.MaxValue; Int2TextBox.Text = int2.ToString();
            uint2 = UInt32.MaxValue; Uint2TextBox.Text = uint2.ToString();
            long2 = Int64.MaxValue; Long2TextBox.Text = long2.ToString();
            ulong2 = UInt64.MaxValue; Ulong2TextBox.Text = ulong2.ToString();
            float2 = Single.MaxValue; Float2TextBox.Text = float2.ToString();
            double2 = Double.MaxValue; Double2TextBox.Text = double2.ToString();
            decimal2 = Decimal.MaxValue; Decimal2TextBox.Text = decimal2.ToString();
        }

        private void Input1TextBox_TextChanged(object sender, EventArgs e)
        {

            try
            {
                byte1 = Convert.ToByte(Input1TextBox.Text);
                Byte1TextBox.Text = byte1.ToString();
            }
            catch (Exception) { Byte1TextBox.Text = "error"; byte1 = 0; }
            try
            {
                sbyte1 = Convert.ToSByte(Input1TextBox.Text);
                Sbyte1TextBox.Text = sbyte1.ToString();
            }
            catch (Exception) { Sbyte1TextBox.Text = "error"; sbyte1 = 0; }
            try
            {
                short1 = Convert.ToInt16(Input1TextBox.Text);
                Short1TextBox.Text = short1.ToString();
            }
            catch (Exception) { Short1TextBox.Text = "error"; short1 = 0; }
            try
            {
                ushort1 = Convert.ToUInt16(Input1TextBox.Text);
                Ushort1TextBox.Text = ushort1.ToString();
            }
            catch (Exception) { Ushort1TextBox.Text = "error"; ushort1 = 0; }
            try
            {
                int1 = Convert.ToInt32(Input1TextBox.Text);
                Int1TextBox.Text = int1.ToString();
            }
            catch (Exception) { Int1TextBox.Text = "error"; int1 = 0; }
            try
            {
                uint1 = Convert.ToUInt32(Input1TextBox.Text);
                Uint1TextBox.Text = uint1.ToString();
            }
            catch (Exception) { Uint1TextBox.Text = "error"; uint1 = 0; }
            try
            {
                long1 = Convert.ToInt64(Input1TextBox.Text);
                Long1TextBox.Text = long1.ToString();
            }
            catch (Exception) { Long1TextBox.Text = "error"; long1 = 0; }
            try
            {
                ulong1 = Convert.ToUInt64(Input1TextBox.Text);
                Ulong1TextBox.Text = ulong1.ToString();
            }
            catch (Exception) { Ulong1TextBox.Text = "error"; ulong1 = 0; }
            try
            {
                float1 = Convert.ToSingle(Input1TextBox.Text);
                Float1TextBox.Text = float1.ToString();
            }
            catch (Exception) { Float1TextBox.Text = "error"; float1 = 0.0f; }
            try
            {
                double1 = Convert.ToDouble(Input1TextBox.Text);
                Double1TextBox.Text = double1.ToString();
            }
            catch (Exception) { Double1TextBox.Text = "error"; double1 = 0.0; }
            try
            {
                decimal1 = Convert.ToDecimal(Input1TextBox.Text);
                Decimal1TextBox.Text = decimal1.ToString();
            }
            catch (Exception) { Decimal1TextBox.Text = "error"; decimal1 = 0m; }
        }
    }
}
