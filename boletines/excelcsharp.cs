                    //var proyecto = CurrentSession.GetAllProyectos(i => i.Id == ProyectoId).FirstOrDefault();
                    //var nombreProyecto = proyecto.Descripcion;
                    //List<string> descripcionesPreguntas = new List<string>();
                    //List<string> encuestadoresCadena = new List<string>();
                    //List<List<ContactoDTO>> contacts = new List<List<ContactoDTO>>();
                    ////dynamic contactos = new JArray();
                    //if (EncuestaId != null)
                    //{
                    //    EncuestaAsociada encuestaP = CurrentSession.GetAllEncuestasAsociadas().Where(x => x.Id == EncuestaId).FirstOrDefault();

                    //    var encuestaInfo = encuestaP.Encuesta;

                    //    ResultadoDTO result = new ResultadoDTO();
                    //    result.EncuestaID = encuestaInfo.Id;

                    //    descripcionesPreguntas = encuestaInfo.EncuestaAcciones.Select(x => x.Descripcion).ToList();

                    //    //encuestadores = encuestaInfo.EncuestaAcciones
                    //    //.SelectMany(x => x.EncuestaContactos)
                    //    //.Select(x => x.Encuestador)
                    //    //.Distinct()
                    //    //.ToList();

                    //    //El numero de veces que se contesto cada pregunta.
                    //    var respuestas = encuestaInfo.EncuestaAcciones.ToList();

                    //    foreach (var res in respuestas)
                    //    {
                    //        var conts = res.EncuestaContactos.ToList();
                    //        //var contactos = conts.Select(i => new
                    //        //{
                    //        //    encuestador = i.Encuestador.NombreApellido,
                    //        //    encuestaNombre = i.EncuestaAsociada.Encuesta.Nombre,
                    //        //    preguntaDescripcion = i.EncuestaAccion.Descripcion,
                    //        //    i.Valor,
                    //        //    i.ValorImagePath,
                    //        //    i.ValorMedia,
                    //        //    i.ValorNumerico
                    //        //}).ToList();
                    //        //contacts.Add(contactos);
                    //        //var json = JsonConvert.SerializeObject(contacts);
                    //        var contactos = conts.Select(i => new ContactoDTO()
                    //        {
                    //            NombreEncuestador = i.Encuestador.NombreApellido,
                    //            NombreEncuesta = i.EncuestaAsociada.Encuesta.Nombre,
                    //            PreguntaDescripcion = i.EncuestaAccion.Descripcion,
                    //            Valor = i.Valor,
                    //            ValorImagen = i.ValorImagePath,
                    //            ValorMedia = i.ValorMedia,
                    //            ValorNumerico = i.ValorNumerico
                    //        }).ToList();

                    //    }

                    //    encuestadoresCadena = encuestaInfo.EncuestaAcciones
                    //    .SelectMany(x => x.EncuestaContactos)
                    //    .Select(x => x.Encuestador.NombreApellido)
                    //    .Distinct()
                    //    .ToList();

                    //}

                    //ExcelPackage excel = new ExcelPackage();
                    //List<string> cList = new List<string>();
                    //var workSheet = excel.Workbook.Worksheets.Add("Detalles de reporte");
                    //var workSheet2 = excel.Workbook.Worksheets.Add("Datos de contacto");
                    //var path = Server.MapPath("/images/") + "smarteyeslogoNew.png";
                    //AddImage(workSheet, 0, 0, path);
                    //var headerTitle = workSheet.Cells[2, 5].LoadFromText("Detalle de auditoría de Encuestas según los siguientes filtros de exportación: ");
                    //var headerProject = workSheet.Cells[3, 5].LoadFromText("Proyecto: " + nombreProyecto);
                    //var headerFont = headerTitle.Style.Font;
                    //headerFont.SetFromFont(new System.Drawing.Font("Palatino Linotype", 18));
                    //headerFont.Bold = false;

                    //var headerFont1 = headerProject.Style.Font;
                    //headerFont1.SetFromFont(new System.Drawing.Font("Palatino Linotype", 18));
                    //headerFont1.Bold = false;



                    //System.Drawing.Color colorSME = System.Drawing.ColorTranslator.FromHtml("#3c89e5");
                    //System.Drawing.Color colorLetras = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
                    //workSheet2.Cells[1, 1].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    //workSheet2.Cells[1, 1].Style.Font.Color.SetColor(colorLetras);
                    //workSheet2.Cells[1, 1].LoadFromText("#").Style.Fill.BackgroundColor.SetColor(colorSME);

                    //workSheet2.Cells[1, 2].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    //workSheet2.Cells[1, 2].Style.Font.Color.SetColor(colorLetras);
                    //workSheet2.Cells[1, 2].LoadFromText("Fecha").Style.Fill.BackgroundColor.SetColor(colorSME);

                    //workSheet2.Cells[1, 3].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    //workSheet2.Cells[1, 3].Style.Font.Color.SetColor(colorLetras);
                    //workSheet2.Cells[1, 3].LoadFromText("Encuestador").Style.Fill.BackgroundColor.SetColor(colorSME);

                    //workSheet2.Cells[1, 4].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    //workSheet2.Cells[1, 4].Style.Font.Color.SetColor(colorLetras);
                    //workSheet2.Cells[1, 4].LoadFromText("Estado").Style.Fill.BackgroundColor.SetColor(colorSME);

                    ////Agregamos las preguntas de la encuesta al excel
                    //int j = 5;
                    //foreach (var descripcion in descripcionesPreguntas)
                    //{
                    //    workSheet2.Cells[1, j].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    //    workSheet2.Cells[1, j].Style.Fill.BackgroundColor.SetColor(colorSME);
                    //    workSheet2.Cells[1, j].Style.Font.Color.SetColor(colorLetras);
                    //    workSheet2.Cells[1, j].Value = descripcion.ToString();
                    //    j++;
                    //}

                    //if (EncuestaId != null)
                    //{
                    //    EncuestaAsociada encuestaP = CurrentSession.GetAllEncuestasAsociadas().Where(x => x.Id == EncuestaId).FirstOrDefault();

                    //    var encuestaInfo = encuestaP.Encuesta;

                    //    ResultadoDTO result = new ResultadoDTO();
                    //    result.EncuestaID = encuestaInfo.Id;

                    //    descripcionesPreguntas = encuestaInfo.EncuestaAcciones.Select(x => x.Descripcion).ToList();

                    //    //encuestadores = encuestaInfo.EncuestaAcciones
                    //    //.SelectMany(x => x.EncuestaContactos)
                    //    //.Select(x => x.Encuestador)
                    //    //.Distinct()
                    //    //.ToList();

                    //    //El numero de veces que se contesto cada pregunta.
                    //    var respuestas = encuestaInfo.EncuestaAcciones.ToList();
                    //    List<ContactoDTO> contactos = new List<ContactoDTO>();
                    //    foreach (var res in respuestas)
                    //    {
                    //        var conts = res.EncuestaContactos.ToList();
                    //        contactos = conts.Select(i => new ContactoDTO()
                    //        {
                    //            NombreEncuestador = i.Encuestador.NombreApellido,
                    //            NombreEncuesta = i.EncuestaAsociada.Encuesta.Nombre,
                    //            PreguntaDescripcion = i.EncuestaAccion.Descripcion,
                    //            Valor = i.Valor,
                    //            ValorImagen = i.ValorImagePath,
                    //            ValorMedia = i.ValorMedia,
                    //            ValorNumerico = i.ValorNumerico
                    //        }).ToList();

                    //        //foreach(var contact in contactos)
                    //        //{
                    //        //    workSheet2.Cells[3, 2].Value = contact.PreguntaDescripcion;
                    //        //}
                    //    }

                    //    encuestadoresCadena = encuestaInfo.EncuestaAcciones
                    //    .SelectMany(x => x.EncuestaContactos)
                    //    .Select(x => x.Encuestador.NombreApellido)
                    //    .Distinct()
                    //    .ToList();

                    //}

                    //using (var memoryStream = new MemoryStream())
                    //{
                    //    Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                    //    Response.AddHeader("content-disposition", "attachment;  filename=Reporte" + DateTime.Now.ToString("dd_MM_yy_hhmmss") + ".xlsx");
                    //    excel.SaveAs(memoryStream);
                    //    memoryStream.WriteTo(Response.OutputStream);
                    //    Response.Flush();
                    //    Response.End();
                    //}