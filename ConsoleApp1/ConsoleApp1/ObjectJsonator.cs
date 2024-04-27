using Newtonsoft.Json;
using System;

namespace ConsoleApp1
{
    public class ObjectJsonator
    {
        public ObjectJsonator()
        {
        }
        public static void Serialize()
        {
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Serialize
            };

            /*using (StreamWriter sw = File.CreateText("../../../assets/objects/monitor.json"))
            {
                sw.Write(JsonConvert.SerializeObject(Monitor(), Formatting.Indented, settings));
            }

            using (StreamWriter sw = File.CreateText("../../../assets/objects/desk.json"))
            {
                sw.Write(JsonConvert.SerializeObject(Desk(), Formatting.Indented, settings));
            }*/
            
            using (StreamWriter sw = File.CreateText("../../../assets/objects/chair.json"))
            {
                sw.Write(JsonConvert.SerializeObject(Chair(), Formatting.Indented, settings));
            }
        }

        public static Object3D Monitor(float offset_x = 0.0f, float offset_y = 0.0f, float offset_z = 0.0f)
        {
            Object3D monitor = new Object3D(offset_x, offset_y, offset_z);
            Part3D head = new Part3D(0.0f, 0.3001f, 0.0f);

            head.Faces.Add("back", new Face(-0.8f, 0.0f, -0.1f, 0.10f, 0.10f, 0.10f,
                                             0.8f, 0.0f, -0.1f, 0.10f, 0.10f, 0.10f,
                                             0.8f, 0.9f, -0.1f, 0.10f, 0.10f, 0.10f,
                                            -0.8f, 0.9f, -0.1f, 0.10f, 0.10f, 0.10f));

            head.Faces.Add("front", new Face(-0.8f, 0.0f, 0.1f, 1.0f, 0.0f, 0.0f,
                                              0.8f, 0.0f, 0.1f, 0.0f, 1.0f, 0.0f,
                                              0.8f, 0.9f, 0.1f, 0.0f, 0.0f, 1.0f,
                                             -0.8f, 0.9f, 0.1f, 0.0f, 1.0f, 0.0f));

            head.Faces.Add("left", new Face(-0.8f, 0.9f, 0.1f, 0.10f, 0.10f, 0.10f,
                                            -0.8f, 0.9f, -0.1f, 0.10f, 0.10f, 0.10f,
                                            -0.8f, 0.0f, -0.1f, 0.10f, 0.10f, 0.10f,
                                            -0.8f, 0.0f, 0.1f, 0.10f, 0.10f, 0.10f));

            head.Faces.Add("right", new Face(0.8f, 0.9f, 0.1f, 0.10f, 0.10f, 0.10f,
                                             0.8f, 0.9f, -0.1f, 0.10f, 0.10f, 0.10f,
                                             0.8f, 0.0f, -0.1f, 0.10f, 0.10f, 0.10f,
                                             0.8f, 0.0f, 0.1f, 0.10f, 0.10f, 0.10f));

            head.Faces.Add("bottom", new Face(-0.8f, 0.0f, -0.1f, 0.10f, 0.10f, 0.10f,
                                               0.8f, 0.0f, -0.1f, 0.10f, 0.10f, 0.10f,
                                               0.8f, 0.0f, 0.1f, 0.10f, 0.10f, 0.10f,
                                              -0.8f, 0.0f, 0.1f, 0.10f, 0.10f, 0.10f));

            head.Faces.Add("top", new Face(-0.8f, 0.9f, -0.1f, 0.10f, 0.10f, 0.10f,
                                            0.8f, 0.9f, -0.1f, 0.10f, 0.10f, 0.10f,
                                            0.8f, 0.9f, 0.1f, 0.10f, 0.10f, 0.10f,
                                           -0.8f, 0.9f, 0.1f, 0.10f, 0.10f, 0.10f));


            monitor.Parts.Add("head", head);

            Part3D neck = new Part3D(0.0f, 0.1001f, 0.0f);

            neck.Faces.Add("back", new Face(-0.05f, 0.0f, -0.05f, 0.10f, 0.10f, 0.10f,
                                             0.05f, 0.0f, -0.05f, 0.10f, 0.10f, 0.10f,
                                             0.05f, 0.2f, -0.05f, 0.10f, 0.10f, 0.10f,
                                            -0.05f, 0.2f, -0.05f, 0.10f, 0.10f, 0.10f));

            neck.Faces.Add("front", new Face(-0.05f, 0.0f, 0.05f, 0.10f, 0.00f, 0.00f,
                                              0.05f, 0.0f, 0.05f, 0.00f, 0.10f, 0.00f,
                                              0.05f, 0.2f, 0.05f, 0.00f, 0.00f, 0.10f,
                                             -0.05f, 0.2f, 0.05f, 0.10f, 0.00f, 0.00f));

            neck.Faces.Add("left", new Face(-0.05f, 0.2f, 0.05f, 0.10f, 0.10f, 0.10f,
                                            -0.05f, 0.2f, -0.05f, 0.10f, 0.10f, 0.10f,
                                            -0.05f, 0.0f, -0.05f, 0.10f, 0.10f, 0.10f,
                                            -0.05f, 0.0f, 0.05f, 0.10f, 0.10f, 0.10f));

            neck.Faces.Add("right", new Face(0.05f, 0.2f, 0.05f, 0.10f, 0.10f, 0.10f,
                                             0.05f, 0.2f, -0.05f, 0.10f, 0.10f, 0.10f,
                                             0.05f, 0.0f, -0.05f, 0.10f, 0.10f, 0.10f,
                                             0.05f, 0.0f, 0.05f, 0.10f, 0.10f, 0.10f));

            neck.Faces.Add("bottom", new Face(-0.05f, 0.0f, -0.05f, 0.10f, 0.10f, 0.10f,
                                               0.05f, 0.0f, -0.05f, 0.10f, 0.10f, 0.10f,
                                               0.05f, 0.0f, 0.05f, 0.10f, 0.10f, 0.10f,
                                              -0.05f, 0.0f, 0.05f, 0.10f, 0.10f, 0.10f));

            neck.Faces.Add("top", new Face(-0.05f, 0.2f, -0.05f, 0.10f, 0.10f, 0.10f,
                                            0.05f, 0.2f, -0.05f, 0.10f, 0.10f, 0.10f,
                                            0.05f, 0.2f, 0.05f, 0.10f, 0.10f, 0.10f,
                                           -0.05f, 0.2f, 0.05f, 0.10f, 0.10f, 0.10f));


            monitor.Parts.Add("neck", neck);

            Part3D _base = new Part3D();

            _base.Faces.Add("back", new Face(-0.2f, 0.0f, -0.3f, 0.10f, 0.10f, 0.10f,
                                              0.2f, 0.0f, -0.3f, 0.10f, 0.10f, 0.10f,
                                              0.2f, 0.1f, -0.3f, 0.10f, 0.10f, 0.10f,
                                             -0.2f, 0.1f, -0.3f, 0.10f, 0.10f, 0.10f));

            _base.Faces.Add("front", new Face(-0.3f, 0.0f, 0.3f, 0.10f, 0.00f, 0.00f,
                                               0.3f, 0.0f, 0.3f, 0.00f, 0.10f, 0.00f,
                                               0.3f, 0.1f, 0.3f, 0.00f, 0.00f, 0.10f,
                                              -0.3f, 0.1f, 0.3f, 0.10f, 0.00f, 0.00f));

            _base.Faces.Add("left", new Face(-0.3f, 0.1f, 0.3f, 0.10f, 0.10f, 0.10f,
                                             -0.2f, 0.1f, -0.3f, 0.10f, 0.10f, 0.10f,
                                             -0.2f, 0.0f, -0.3f, 0.10f, 0.10f, 0.10f,
                                             -0.3f, 0.0f, 0.3f, 0.10f, 0.10f, 0.10f));

            _base.Faces.Add("right", new Face(0.3f, 0.1f, 0.3f, 0.10f, 0.10f, 0.10f,
                                              0.2f, 0.1f, -0.3f, 0.10f, 0.10f, 0.10f,
                                              0.2f, 0.0f, -0.3f, 0.10f, 0.10f, 0.10f,
                                              0.3f, 0.0f, 0.3f, 0.10f, 0.10f, 0.10f));

            _base.Faces.Add("bottom", new Face(-0.2f, 0.0f, -0.3f, 0.10f, 0.10f, 0.10f,
                                                0.2f, 0.0f, -0.3f, 0.10f, 0.10f, 0.10f,
                                                0.3f, 0.0f, 0.3f, 0.10f, 0.10f, 0.10f,
                                               -0.3f, 0.0f, 0.3f, 0.10f, 0.10f, 0.10f));

            _base.Faces.Add("top", new Face(-0.2f, 0.1f, -0.3f, 0.10f, 0.10f, 0.10f,
                                             0.2f, 0.1f, -0.3f, 0.10f, 0.10f, 0.10f,
                                             0.3f, 0.1f, 0.3f, 0.10f, 0.10f, 0.10f,
                                            -0.3f, 0.1f, 0.3f, 0.10f, 0.10f, 0.10f));

            monitor.Parts.Add("base", _base);

            return monitor;
        }

        public static Object3D Desk(float offset_x = 0.0f, float offset_y = 0.0f, float offset_z = 0.0f)
        {
            Object3D desk = new Object3D(offset_x, offset_y, offset_z);
            Part3D table = new Part3D(0.0f, -0.0001f, 0.0f);

            table.Faces.Add("back", new Face(-1.5f, -0.1f, -1.0f, 0.659f, 0.373f, 0.098f,
                                              1.5f, -0.1f, -1.0f, 0.659f, 0.373f, 0.098f,
                                              1.5f,  0.0f, -1.0f, 0.659f, 0.373f, 0.098f,
                                             -1.5f,  0.0f, -1.0f, 0.659f, 0.373f, 0.098f));

            table.Faces.Add("front", new Face(-1.5f, -0.1f, 1.0f, 0.659f, 0.373f, 0.098f,
                                               1.5f, -0.1f, 1.0f, 0.659f, 0.373f, 0.098f,
                                               1.5f,  0.0f, 1.0f, 0.659f, 0.373f, 0.098f,
                                              -1.5f,  0.0f, 1.0f, 0.659f, 0.373f, 0.098f));

            table.Faces.Add("left", new Face(-1.5f,  0.0f,  1.0f, 0.629f, 0.373f, 0.098f,
                                             -1.5f,  0.0f, -1.0f, 0.629f, 0.373f, 0.098f,
                                             -1.5f, -0.1f, -1.0f, 0.629f, 0.373f, 0.098f,
                                             -1.5f, -0.1f,  1.0f, 0.629f, 0.373f, 0.098f));

            table.Faces.Add("right", new Face(1.5f,  0.0f,  1.0f, 0.629f, 0.373f, 0.098f,
                                              1.5f,  0.0f, -1.0f, 0.629f, 0.373f, 0.098f,
                                              1.5f, -0.1f, -1.0f, 0.629f, 0.373f, 0.098f,
                                              1.5f, -0.1f,  1.0f, 0.629f, 0.373f, 0.098f));

            table.Faces.Add("bottom", new Face(-1.5f, -0.1f, -1.0f, 0.689f, 0.373f, 0.098f,
                                                1.5f, -0.1f, -1.0f, 0.689f, 0.373f, 0.098f,
                                                1.5f, -0.1f,  1.0f, 0.689f, 0.373f, 0.098f,
                                               -1.5f, -0.1f,  1.0f, 0.689f, 0.373f, 0.098f));

            table.Faces.Add("top", new Face(-1.5f,  0.0f, -1.0f, 0.689f, 0.373f, 0.098f,
                                             1.5f,  0.0f, -1.0f, 0.689f, 0.373f, 0.098f,
                                             1.5f,  0.0f,  1.0f, 0.689f, 0.373f, 0.098f,
                                            -1.5f,  0.0f,  1.0f, 0.689f, 0.373f, 0.098f));


            desk.Parts.Add("table", table);

            Part3D leftLeg = new Part3D(-1.4f, -0.1001f, 0.0f);

            leftLeg.Faces.Add("back", new Face(-0.05f, -1.65f, -0.95f, 0.2f, 0.2f, 0.2f,
                                                0.05f, -1.65f, -0.95f, 0.2f, 0.2f, 0.2f,
                                                0.05f,  0.0f,  -0.95f, 0.2f, 0.2f, 0.2f,
                                               -0.05f,  0.0f,  -0.95f, 0.2f, 0.2f, 0.2f));

            leftLeg.Faces.Add("front", new Face(-0.05f, -1.65f, 0.95f, 0.2f, 0.2f, 0.2f,
                                                 0.05f, -1.65f, 0.95f, 0.2f, 0.2f, 0.2f,
                                                 0.05f,  0.0f,  0.95f, 0.2f, 0.2f, 0.2f,
                                                -0.05f,  0.0f,  0.95f, 0.2f, 0.2f, 0.2f));

            leftLeg.Faces.Add("left", new Face(-0.05f,  0.0f,   0.95f, 0.225f, 0.225f, 0.225f,
                                               -0.05f,  0.0f,  -0.95f, 0.225f, 0.225f, 0.225f,
                                               -0.05f, -1.65f, -0.95f, 0.225f, 0.225f, 0.225f,
                                               -0.05f, -1.65f,  0.95f, 0.225f, 0.225f, 0.225f));

            leftLeg.Faces.Add("right", new Face(0.05f,  0.0f,   0.95f, 0.225f, 0.225f, 0.225f,
                                                0.05f,  0.0f,  -0.95f, 0.225f, 0.225f, 0.225f,
                                                0.05f, -1.65f, -0.95f, 0.225f, 0.225f, 0.225f,
                                                0.05f, -1.65f,  0.95f, 0.225f, 0.225f, 0.225f));

            leftLeg.Faces.Add("bottom", new Face(-0.05f, -1.65f, -0.95f, 0.25f, 0.25f, 0.25f,
                                                  0.05f, -1.65f, -0.95f, 0.25f, 0.25f, 0.25f,
                                                  0.05f, -1.65f,  0.95f, 0.25f, 0.25f, 0.25f,
                                                 -0.05f, -1.65f,  0.95f, 0.25f, 0.25f, 0.25f));

            leftLeg.Faces.Add("top", new Face(-0.05f, 0.0f, -0.95f, 0.25f, 0.25f, 0.25f,
                                               0.05f, 0.0f, -0.95f, 0.25f, 0.25f, 0.25f,
                                               0.05f, 0.0f,  0.95f, 0.25f, 0.25f, 0.25f,
                                              -0.05f, 0.0f,  0.95f, 0.25f, 0.25f, 0.25f));


            desk.Parts.Add("leftLeg", leftLeg);

            Part3D rightLeg = new Part3D(1.4f, -0.1001f, 0.0f);

            rightLeg.Faces.Add("back", new Face(-0.05f, -1.65f, -0.95f, 0.2f, 0.2f, 0.2f,
                                                 0.05f, -1.65f, -0.95f, 0.2f, 0.2f, 0.2f,
                                                 0.05f,  0.0f,  -0.95f, 0.2f, 0.2f, 0.2f,
                                                -0.05f,  0.0f,  -0.95f, 0.2f, 0.2f, 0.2f));

            rightLeg.Faces.Add("front", new Face(-0.05f, -1.65f, 0.95f, 0.2f, 0.2f, 0.2f,
                                                  0.05f, -1.65f, 0.95f, 0.2f, 0.2f, 0.2f,
                                                  0.05f,  0.0f,  0.95f, 0.2f, 0.2f, 0.2f,
                                                 -0.05f,  0.0f,  0.95f, 0.2f, 0.2f, 0.2f));

            rightLeg.Faces.Add("left", new Face(-0.05f,  0.0f,   0.95f, 0.225f, 0.225f, 0.225f,
                                                -0.05f,  0.0f,  -0.95f, 0.225f, 0.225f, 0.225f,
                                                -0.05f, -1.65f, -0.95f, 0.225f, 0.225f, 0.225f,
                                                -0.05f, -1.65f,  0.95f, 0.225f, 0.225f, 0.225f));

            rightLeg.Faces.Add("right", new Face(0.05f,  0.0f,   0.95f, 0.225f, 0.225f, 0.225f,
                                                 0.05f,  0.0f,  -0.95f, 0.225f, 0.225f, 0.225f,
                                                 0.05f, -1.65f, -0.95f, 0.225f, 0.225f, 0.225f,
                                                 0.05f, -1.65f,  0.95f, 0.225f, 0.225f, 0.225f));

            rightLeg.Faces.Add("bottom", new Face(-0.05f, -1.65f, -0.95f, 0.25f, 0.25f, 0.25f,
                                                   0.05f, -1.65f, -0.95f, 0.25f, 0.25f, 0.25f,
                                                   0.05f, -1.65f,  0.95f, 0.25f, 0.25f, 0.25f,
                                                  -0.05f, -1.65f,  0.95f, 0.25f, 0.25f, 0.25f));

            rightLeg.Faces.Add("top", new Face(-0.05f, 0.0f, -0.95f, 0.25f, 0.25f, 0.25f,
                                                0.05f, 0.0f, -0.95f, 0.25f, 0.25f, 0.25f,
                                                0.05f, 0.0f,  0.95f, 0.25f, 0.25f, 0.25f,
                                               -0.05f, 0.0f,  0.95f, 0.25f, 0.25f, 0.25f));

            desk.Parts.Add("rightLeg", rightLeg);

            Part3D legBreak = new Part3D(0.0f, -0.1001f, 0.0f);

            legBreak.Faces.Add("back", new Face(-1.35f, -0.7f, -0.95f, 0.2f, 0.2f, 0.2f,
                                                 1.35f, -0.7f, -0.95f, 0.2f, 0.2f, 0.2f,
                                                 1.35f,  0.0f, -0.95f, 0.2f, 0.2f, 0.2f,
                                                -1.35f,  0.0f, -0.95f, 0.2f, 0.2f, 0.2f));

            legBreak.Faces.Add("front", new Face(-1.35f, -0.7f, -0.85f, 0.2f, 0.2f, 0.2f,
                                                  1.35f, -0.7f, -0.85f, 0.2f, 0.2f, 0.2f,
                                                  1.35f,  0.0f, -0.85f, 0.2f, 0.2f, 0.2f,
                                                 -1.35f,  0.0f, -0.85f, 0.2f, 0.2f, 0.2f));

            legBreak.Faces.Add("left", new Face(-1.35f,  0.0f, -0.85f, 0.225f, 0.225f, 0.225f,
                                                -1.35f,  0.0f, -0.95f, 0.225f, 0.225f, 0.225f,
                                                -1.35f, -0.7f, -0.95f, 0.225f, 0.225f, 0.225f,
                                                -1.35f, -0.7f, -0.85f, 0.225f, 0.225f, 0.225f));

            legBreak.Faces.Add("right", new Face(1.35f,  0.0f, -0.85f, 0.225f, 0.225f, 0.225f,
                                                 1.35f,  0.0f, -0.95f, 0.225f, 0.225f, 0.225f,
                                                 1.35f, -0.7f, -0.95f, 0.225f, 0.225f, 0.225f,
                                                 1.35f, -0.7f, -0.85f, 0.225f, 0.225f, 0.225f));

            legBreak.Faces.Add("bottom", new Face(1.35f, -0.7f, -0.95f, 0.25f, 0.25f, 0.25f,
                                                 -1.35f, -0.7f, -0.95f, 0.25f, 0.25f, 0.25f,
                                                 -1.35f, -0.7f, -0.85f, 0.25f, 0.25f, 0.25f,
                                                  1.35f, -0.7f, -0.85f, 0.25f, 0.25f, 0.25f));

            legBreak.Faces.Add("top", new Face(1.35f, 0.0f, -0.95f, 0.25f, 0.25f, 0.25f,
                                              -1.35f, 0.0f, -0.95f, 0.25f, 0.25f, 0.25f,
                                              -1.35f, 0.0f, -0.85f, 0.25f, 0.25f, 0.25f,
                                               1.35f, 0.0f, -0.85f, 0.25f, 0.25f, 0.25f));


            desk.Parts.Add("legBreak", legBreak);

            return desk;
        }

        public static Object3D Chair(float offset_x = 0.0f, float offset_y = 0.0f, float offset_z = 0.0f)
        {
            Object3D chair = new Object3D(offset_x, offset_y, offset_z);
            Part3D sit = new Part3D(0.0f, -0.7001f, 1.75f);

            sit.Faces.Add("back", new Face(-0.75f, -0.1f, -0.75f, 0.659f, 0.373f, 0.098f,
                                            0.75f, -0.1f, -0.75f, 0.659f, 0.373f, 0.098f,
                                            0.75f,  0.0f, -0.75f, 0.659f, 0.373f, 0.098f,
                                           -0.75f,  0.0f, -0.75f, 0.659f, 0.373f, 0.098f));

            sit.Faces.Add("front", new Face(-0.75f, -0.1f, 0.75f, 0.659f, 0.373f, 0.098f,
                                             0.75f, -0.1f, 0.75f, 0.659f, 0.373f, 0.098f,
                                             0.75f,  0.0f, 0.75f, 0.659f, 0.373f, 0.098f,
                                            -0.75f,  0.0f, 0.75f, 0.659f, 0.373f, 0.098f));

            sit.Faces.Add("left", new Face(-0.75f,  0.0f, 0.75f, 0.629f, 0.373f, 0.098f,
                                           -0.75f,  0.0f,-0.75f, 0.629f, 0.373f, 0.098f,
                                           -0.75f, -0.1f,-0.75f, 0.629f, 0.373f, 0.098f,
                                           -0.75f, -0.1f, 0.75f, 0.629f, 0.373f, 0.098f));

            sit.Faces.Add("right", new Face(0.75f,  0.0f, 0.75f, 0.629f, 0.373f, 0.098f,
                                            0.75f,  0.0f,-0.75f, 0.629f, 0.373f, 0.098f,
                                            0.75f, -0.1f,-0.75f, 0.629f, 0.373f, 0.098f,
                                            0.75f, -0.1f, 0.75f, 0.629f, 0.373f, 0.098f));

            sit.Faces.Add("bottom", new Face(-0.75f, -0.1f, -0.75f, 0.689f, 0.373f, 0.098f,
                                              0.75f, -0.1f, -0.75f, 0.689f, 0.373f, 0.098f,
                                              0.75f, -0.1f,  0.75f, 0.689f, 0.373f, 0.098f,
                                             -0.75f, -0.1f,  0.75f, 0.689f, 0.373f, 0.098f));

            sit.Faces.Add("top", new Face(-0.75f, 0.0f,-0.75f, 0.689f, 0.373f, 0.098f,
                                           0.75f, 0.0f,-0.75f, 0.689f, 0.373f, 0.098f,
                                           0.75f, 0.0f, 0.75f, 0.689f, 0.373f, 0.098f,
                                          -0.75f, 0.0f, 0.75f, 0.689f, 0.373f, 0.098f));


            chair.Parts.Add("sit", sit);

            Part3D frontLeftLeg = new Part3D(-0.7f, -0.8001f, 1.05f);

            frontLeftLeg.Faces.Add("back", new Face(-0.05f, -0.95f, -0.05f, 0.659f, 0.373f, 0.098f,
                                                     0.05f, -0.95f, -0.05f, 0.659f, 0.373f, 0.098f,
                                                     0.05f,  0.0f,  -0.05f, 0.659f, 0.373f, 0.098f,
                                                    -0.05f,  0.0f,  -0.05f, 0.659f, 0.373f, 0.098f));

            frontLeftLeg.Faces.Add("front", new Face(-0.05f, -0.95f, 0.05f, 0.659f, 0.373f, 0.098f,
                                                      0.05f, -0.95f, 0.05f, 0.659f, 0.373f, 0.098f,
                                                      0.05f,  0.0f,  0.05f, 0.659f, 0.373f, 0.098f,
                                                     -0.05f,  0.0f,  0.05f, 0.659f, 0.373f, 0.098f));

            frontLeftLeg.Faces.Add("left", new Face(-0.05f,  0.0f,   0.05f, 0.629f, 0.373f, 0.098f,
                                                    -0.05f,  0.0f,  -0.05f, 0.629f, 0.373f, 0.098f,
                                                    -0.05f, -0.95f, -0.05f, 0.629f, 0.373f, 0.098f,
                                                    -0.05f, -0.95f,  0.05f, 0.629f, 0.373f, 0.098f));

            frontLeftLeg.Faces.Add("right", new Face(0.05f,  0.0f,  0.05f, 0.629f, 0.373f, 0.098f,
                                                     0.05f,  0.0f, -0.05f, 0.629f, 0.373f, 0.098f,
                                                     0.05f, -0.95f,-0.05f, 0.629f, 0.373f, 0.098f,
                                                     0.05f, -0.95f, 0.05f, 0.629f, 0.373f, 0.098f));

            frontLeftLeg.Faces.Add("bottom", new Face(-0.05f, -0.95f, -0.05f, 0.689f, 0.373f, 0.098f,
                                                       0.05f, -0.95f, -0.05f, 0.689f, 0.373f, 0.098f,
                                                       0.05f, -0.95f,  0.05f, 0.689f, 0.373f, 0.098f,
                                                      -0.05f, -0.95f,  0.05f, 0.689f, 0.373f, 0.098f));

            frontLeftLeg.Faces.Add("top", new Face(-0.05f, 0.0f, -0.05f, 0.689f, 0.373f, 0.098f,
                                                    0.05f, 0.0f, -0.05f, 0.689f, 0.373f, 0.098f,
                                                    0.05f, 0.0f,  0.05f, 0.689f, 0.373f, 0.098f,
                                                   -0.05f, 0.0f,  0.05f, 0.689f, 0.373f, 0.098f));


            chair.Parts.Add("frontLeftLeg", frontLeftLeg);

            Part3D frontRightLeg = new Part3D(0.7f, -0.8001f, 1.05f);

            frontRightLeg.Faces.Add("back", new Face(-0.05f, -0.95f, -0.05f, 0.659f, 0.373f, 0.098f,
                                                     0.05f, -0.95f, -0.05f, 0.659f, 0.373f, 0.098f,
                                                     0.05f, 0.0f, -0.05f, 0.659f, 0.373f, 0.098f,
                                                    -0.05f, 0.0f, -0.05f, 0.659f, 0.373f, 0.098f));

            frontRightLeg.Faces.Add("front", new Face(-0.05f, -0.95f, 0.05f, 0.659f, 0.373f, 0.098f,
                                                      0.05f, -0.95f, 0.05f, 0.659f, 0.373f, 0.098f,
                                                      0.05f, 0.0f, 0.05f, 0.659f, 0.373f, 0.098f,
                                                     -0.05f, 0.0f, 0.05f, 0.659f, 0.373f, 0.098f));

            frontRightLeg.Faces.Add("left", new Face(-0.05f, 0.0f, 0.05f, 0.629f, 0.373f, 0.098f,
                                                    -0.05f, 0.0f, -0.05f, 0.629f, 0.373f, 0.098f,
                                                    -0.05f, -0.95f, -0.05f, 0.629f, 0.373f, 0.098f,
                                                    -0.05f, -0.95f, 0.05f, 0.629f, 0.373f, 0.098f));

            frontRightLeg.Faces.Add("right", new Face(0.05f, 0.0f, 0.05f, 0.629f, 0.373f, 0.098f,
                                                     0.05f, 0.0f, -0.05f, 0.629f, 0.373f, 0.098f,
                                                     0.05f, -0.95f, -0.05f, 0.629f, 0.373f, 0.098f,
                                                     0.05f, -0.95f, 0.05f, 0.629f, 0.373f, 0.098f));

            frontRightLeg.Faces.Add("bottom", new Face(-0.05f, -0.95f, -0.05f, 0.689f, 0.373f, 0.098f,
                                                       0.05f, -0.95f, -0.05f, 0.689f, 0.373f, 0.098f,
                                                       0.05f, -0.95f, 0.05f, 0.689f, 0.373f, 0.098f,
                                                      -0.05f, -0.95f, 0.05f, 0.689f, 0.373f, 0.098f));

            frontRightLeg.Faces.Add("top", new Face(-0.05f, 0.0f, -0.05f, 0.689f, 0.373f, 0.098f,
                                                    0.05f, 0.0f, -0.05f, 0.689f, 0.373f, 0.098f,
                                                    0.05f, 0.0f, 0.05f, 0.689f, 0.373f, 0.098f,
                                                   -0.05f, 0.0f, 0.05f, 0.689f, 0.373f, 0.098f));


            chair.Parts.Add("frontRightLeg", frontRightLeg);

            Part3D backLeftLeg = new Part3D(-0.7f, -0.8001f, 2.45f);

            backLeftLeg.Faces.Add("back", new Face(-0.05f, -0.95f, -0.05f, 0.659f, 0.373f, 0.098f,
                                                     0.05f, -0.95f, -0.05f, 0.659f, 0.373f, 0.098f,
                                                     0.05f, 0.0f, -0.05f, 0.659f, 0.373f, 0.098f,
                                                    -0.05f, 0.0f, -0.05f, 0.659f, 0.373f, 0.098f));

            backLeftLeg.Faces.Add("front", new Face(-0.05f, -0.95f, 0.05f, 0.659f, 0.373f, 0.098f,
                                                      0.05f, -0.95f, 0.05f, 0.659f, 0.373f, 0.098f,
                                                      0.05f, 0.0f, 0.05f, 0.659f, 0.373f, 0.098f,
                                                     -0.05f, 0.0f, 0.05f, 0.659f, 0.373f, 0.098f));

            backLeftLeg.Faces.Add("left", new Face(-0.05f, 0.0f, 0.05f, 0.629f, 0.373f, 0.098f,
                                                    -0.05f, 0.0f, -0.05f, 0.629f, 0.373f, 0.098f,
                                                    -0.05f, -0.95f, -0.05f, 0.629f, 0.373f, 0.098f,
                                                    -0.05f, -0.95f, 0.05f, 0.629f, 0.373f, 0.098f));

            backLeftLeg.Faces.Add("right", new Face(0.05f, 0.0f, 0.05f, 0.629f, 0.373f, 0.098f,
                                                     0.05f, 0.0f, -0.05f, 0.629f, 0.373f, 0.098f,
                                                     0.05f, -0.95f, -0.05f, 0.629f, 0.373f, 0.098f,
                                                     0.05f, -0.95f, 0.05f, 0.629f, 0.373f, 0.098f));

            backLeftLeg.Faces.Add("bottom", new Face(-0.05f, -0.95f, -0.05f, 0.689f, 0.373f, 0.098f,
                                                       0.05f, -0.95f, -0.05f, 0.689f, 0.373f, 0.098f,
                                                       0.05f, -0.95f, 0.05f, 0.689f, 0.373f, 0.098f,
                                                      -0.05f, -0.95f, 0.05f, 0.689f, 0.373f, 0.098f));

            backLeftLeg.Faces.Add("top", new Face(-0.05f, 0.0f, -0.05f, 0.689f, 0.373f, 0.098f,
                                                    0.05f, 0.0f, -0.05f, 0.689f, 0.373f, 0.098f,
                                                    0.05f, 0.0f, 0.05f, 0.689f, 0.373f, 0.098f,
                                                   -0.05f, 0.0f, 0.05f, 0.689f, 0.373f, 0.098f));

            chair.Parts.Add("backLeftLeg", backLeftLeg);

            Part3D backRightLeg = new Part3D( 0.7f, -0.8001f, 2.45f);

            backRightLeg.Faces.Add("back", new Face(-0.05f, -0.95f, -0.05f, 0.659f, 0.373f, 0.098f,
                                                     0.05f, -0.95f, -0.05f, 0.659f, 0.373f, 0.098f,
                                                     0.05f, 0.0f, -0.05f, 0.659f, 0.373f, 0.098f,
                                                    -0.05f, 0.0f, -0.05f, 0.659f, 0.373f, 0.098f));

            backRightLeg.Faces.Add("front", new Face(-0.05f, -0.95f, 0.05f, 0.659f, 0.373f, 0.098f,
                                                      0.05f, -0.95f, 0.05f, 0.659f, 0.373f, 0.098f,
                                                      0.05f, 0.0f, 0.05f, 0.659f, 0.373f, 0.098f,
                                                     -0.05f, 0.0f, 0.05f, 0.659f, 0.373f, 0.098f));

            backRightLeg.Faces.Add("left", new Face(-0.05f, 0.0f, 0.05f, 0.629f, 0.373f, 0.098f,
                                                    -0.05f, 0.0f, -0.05f, 0.629f, 0.373f, 0.098f,
                                                    -0.05f, -0.95f, -0.05f, 0.629f, 0.373f, 0.098f,
                                                    -0.05f, -0.95f, 0.05f, 0.629f, 0.373f, 0.098f));

            backRightLeg.Faces.Add("right", new Face(0.05f, 0.0f, 0.05f, 0.629f, 0.373f, 0.098f,
                                                     0.05f, 0.0f, -0.05f, 0.629f, 0.373f, 0.098f,
                                                     0.05f, -0.95f, -0.05f, 0.629f, 0.373f, 0.098f,
                                                     0.05f, -0.95f, 0.05f, 0.629f, 0.373f, 0.098f));

            backRightLeg.Faces.Add("bottom", new Face(-0.05f, -0.95f, -0.05f, 0.689f, 0.373f, 0.098f,
                                                       0.05f, -0.95f, -0.05f, 0.689f, 0.373f, 0.098f,
                                                       0.05f, -0.95f, 0.05f, 0.689f, 0.373f, 0.098f,
                                                      -0.05f, -0.95f, 0.05f, 0.689f, 0.373f, 0.098f));

            backRightLeg.Faces.Add("top", new Face(-0.05f, 0.0f, -0.05f, 0.689f, 0.373f, 0.098f,
                                                    0.05f, 0.0f, -0.05f, 0.689f, 0.373f, 0.098f,
                                                    0.05f, 0.0f, 0.05f, 0.689f, 0.373f, 0.098f,
                                                   -0.05f, 0.0f, 0.05f, 0.689f, 0.373f, 0.098f));

            chair.Parts.Add("backRightLeg", backRightLeg);

            Part3D espalda = new Part3D(0.0f,-0.7001f,2.45f);

            espalda.Faces.Add("back", new Face(-0.75f, 0.0f, -0.05f, 0.659f, 0.373f, 0.098f,
                                                0.75f, 0.0f, -0.05f, 0.659f, 0.373f, 0.098f,
                                                0.75f, 1.7f, -0.05f, 0.659f, 0.373f, 0.098f,
                                               -0.75f, 1.7f, -0.05f, 0.659f, 0.373f, 0.098f));

            espalda.Faces.Add("front", new Face(-0.75f, 0.0f, 0.05f, 0.659f, 0.373f, 0.098f,
                                                 0.75f, 0.0f, 0.05f, 0.659f, 0.373f, 0.098f,
                                                 0.75f, 1.7f, 0.05f, 0.659f, 0.373f, 0.098f,
                                                -0.75f, 1.7f, 0.05f, 0.659f, 0.373f, 0.098f));

            espalda.Faces.Add("left", new Face(-0.75f, 1.7f,  0.05f, 0.629f, 0.373f, 0.098f,
                                               -0.75f, 1.7f, -0.05f, 0.629f, 0.373f, 0.098f,
                                               -0.75f, 0.0f, -0.05f, 0.629f, 0.373f, 0.098f,
                                               -0.75f, 0.0f,  0.05f, 0.629f, 0.373f, 0.098f));

            espalda.Faces.Add("right", new Face(0.75f, 1.7f,  0.05f, 0.629f, 0.373f, 0.098f,
                                                0.75f, 1.7f, -0.05f, 0.629f, 0.373f, 0.098f,
                                                0.75f, 0.0f, -0.05f, 0.629f, 0.373f, 0.098f,
                                                0.75f, 0.0f,  0.05f, 0.629f, 0.373f, 0.098f));

            espalda.Faces.Add("bottom", new Face(-0.75f, 0.0f, -0.05f, 0.689f, 0.373f, 0.098f,
                                                  0.75f, 0.0f, -0.05f, 0.689f, 0.373f, 0.098f,
                                                  0.75f, 0.0f,  0.05f, 0.689f, 0.373f, 0.098f,
                                                 -0.75f, 0.0f,  0.05f, 0.689f, 0.373f, 0.098f));

            espalda.Faces.Add("top", new Face(-0.75f, 1.7f, -0.05f, 0.689f, 0.373f, 0.098f,
                                               0.75f, 1.7f, -0.05f, 0.689f, 0.373f, 0.098f,
                                               0.75f, 1.7f,  0.05f, 0.689f, 0.373f, 0.098f,
                                              -0.75f, 1.7f,  0.05f, 0.689f, 0.373f, 0.098f));

            chair.Parts.Add("espalda", espalda);

            return chair;
        }


    }
}