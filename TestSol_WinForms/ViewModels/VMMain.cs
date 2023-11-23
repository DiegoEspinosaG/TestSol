using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestSol_WinForms.Models.DTO;

namespace TestSol_WinForms.ViewModels
{
    internal class VMMain
    {
        public class ResponseEmpleado
        {
            public int statusCode { get; set; }
            public bool isExitoso { get; set; }
            public object errorMessages { get; set; }
            public List<EmpleadoDto> resultado { get; set; }
        }

        public class ResponseArea
        {
            public int statusCode { get; set; }
            public bool isExitoso { get; set; }
            public object errorMessages { get; set; }
            public List<AreaDto> resultado { get; set; }
        }

        public async void InitMain(FrmMain frm)
        {
			try
			{                
                try
                {
                    string resource = $"api/Empleado/";

                    string result = await Utilidades.Get(resource);

                    ResponseEmpleado getResult = new ResponseEmpleado();

                    if (result != null) getResult = JsonConvert.DeserializeObject<ResponseEmpleado>(result);

                    frm.DGVShow.DataSource = getResult.resultado;

                    frm.DGVShow.Columns["EmpleadoID"].Visible = true;
                    frm.DGVShow.Columns["EmpleadoID"].HeaderText = "ID";

                    frm.DGVShow.Columns["Nombre"].Visible = true;
                    frm.DGVShow.Columns["Nombre"].HeaderText = "Nombre";

                    frm.DGVShow.Columns["ApellidoPaterno"].Visible = true;
                    frm.DGVShow.Columns["ApellidoPaterno"].HeaderText = "Apellido Paterno";

                    frm.DGVShow.Columns["ApellidoMaterno"].Visible = true;
                    frm.DGVShow.Columns["ApellidoMaterno"].HeaderText = "Apellido Materno";

                    frm.DGVShow.Columns["AreaID"].Visible = true;
                    frm.DGVShow.Columns["AreaID"].HeaderText = "Area";

                    frm.DGVShow.Columns["FechaNacimiento"].Visible = true;
                    frm.DGVShow.Columns["FechaNacimiento"].HeaderText = "Fecha Nacimiento";

                    frm.DGVShow.Columns["Sueldo"].Visible = true;
                    frm.DGVShow.Columns["Sueldo"].HeaderText = "Sueldo";
                }
                catch (Exception)
                {
                    MessageBox.Show("Algo salió mal en el get");
                }

                try
                {
                    string resource = $"api/Area/";

                    string result = await Utilidades.Get(resource);

                    ResponseArea getResult = new ResponseArea();

                    if (result != null) getResult = JsonConvert.DeserializeObject<ResponseArea>(result);

                    frm.CmbAreaAdd.DataSource = getResult.resultado;

                    frm.CmbAreaAdd.ValueMember = "AreaId";
                    frm.CmbAreaAdd.DisplayMember = "Area1";

                    frm.CmbAreaUp.DataSource = getResult.resultado;

                    frm.CmbAreaUp.ValueMember = "AreaId";
                    frm.CmbAreaUp.DisplayMember = "Area1";
                }
                catch (Exception)
                {
                    MessageBox.Show("Algo salió mal en el get");
                }
            }
			catch (Exception ex)
			{
				MessageBox.Show($"Excepción al mostrar los registros. {ex.Message}", "Excepción", 
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
        }

        public async void AgregarEmpleado(FrmMain frm)
        {
            try
            {
                if (frm.TxtNameAdd.TextLength <= 0 || frm.TxtApePatAdd.TextLength <= 0 
                    || frm.TxtApeMatAdd.TextLength <= 0 || frm.TxtSueldoAdd.TextLength <= 0)
                {
                    MessageBox.Show("No ha terminado de llenar los campos.", "Atención", MessageBoxButtons.OK); 
                    return;
                }

                EmpleadoDto empleado = new EmpleadoDto()
                {
                    EmpleadoId = Guid.NewGuid().ToString().Substring(0, 6),
                    Nombre = frm.TxtNameAdd.Text,
                    ApellidoPaterno = frm.TxtApePatAdd.Text,
                    ApellidoMaterno = frm.TxtApeMatAdd.Text,
                    AreaId = frm.CmbAreaAdd.SelectedValue.ToString(),
                    FechaNacimiento = frm.DTPFechaNacAdd.Value,
                    Sueldo = Convert.ToDouble(frm.TxtSueldoAdd.Text),
                };

                string json = JsonConvert.SerializeObject(empleado, Formatting.Indented);

                string resource = $"api/Empleado/";

                string result = await Utilidades.Post(json, resource);

                ResponseEmpleado postResult = new ResponseEmpleado();

                if (result != null) postResult = JsonConvert.DeserializeObject<ResponseEmpleado>(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Excepción al agregar el registro. {ex.Message}", "Excepción",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async void ActualizarEmpleado(FrmMain frm)
        {
            try
            {
                if (frm.TxtNameUp.TextLength <= 0 || frm.TxtApePatUp.TextLength <= 0
                    || frm.TxtApeMatUp.TextLength <= 0 || frm.TxtSueldoUp.TextLength <= 0)
                {
                    MessageBox.Show("No ha terminado de llenar los campos.", "Atención", MessageBoxButtons.OK);
                    return;
                }

                EmpleadoDto empleado = new EmpleadoDto()
                {
                    EmpleadoId = frm.TxtIdUp.Text,
                    Nombre = frm.TxtNameUp.Text,
                    ApellidoPaterno = frm.TxtApePatUp.Text,
                    ApellidoMaterno = frm.TxtApeMatUp.Text,
                    AreaId = frm.CmbAreaUp.SelectedValue.ToString(),
                    FechaNacimiento = frm.DTPFechaNacUp.Value,
                    Sueldo = Convert.ToDouble(frm.TxtSueldoUp.Text),
                };

                string json = JsonConvert.SerializeObject(empleado, Formatting.Indented);

                string resource = $"api/Empleado/id:int?id={empleado.EmpleadoId}";

                string result = await Utilidades.Put(json, resource);

                ResponseEmpleado postResult = new ResponseEmpleado();

                if (result != null) postResult = JsonConvert.DeserializeObject<ResponseEmpleado>(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Excepción al actualizar el registro. {ex.Message}", "Excepción",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async void BorrarEmpleado(FrmMain frm)
        {
            try
            {
                if (frm.TxtIdDel.TextLength <= 0)
                {
                    MessageBox.Show("No ha terminado de llenar los campos.", "Atención", MessageBoxButtons.OK);
                    return;
                }

                string resource = $"api/Empleado/id:int?id={frm.TxtIdDel.Text}";

                string result = await Utilidades.Delete(resource);

                ResponseEmpleado postResult = new ResponseEmpleado();

                if (result != null) postResult = JsonConvert.DeserializeObject<ResponseEmpleado>(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Excepción al actualizar el registro. {ex.Message}", "Excepción",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
