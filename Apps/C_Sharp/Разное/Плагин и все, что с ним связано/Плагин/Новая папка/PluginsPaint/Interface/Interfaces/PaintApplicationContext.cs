using System;
using System.Drawing;
using System.Windows.Forms;


namespace Oop.Tasks.Paint.Interface
{
  // ���������, ����������� �������� ����������
  //
  public interface IPaintApplicationContext
  {
    // �������� ����������� �����������
    // (���������� �������� ����� �������
    // ��������� �����������, �.�. �����������
    // ������������� �� ����������)
    void Invalidate();

    // ������������� �����������
    Bitmap Image { get; }

    // ������� ����� ������������� �����������
    // ������ �������� (������ �����������
    // ����� ��������)
    // (�������� ������ ��� �������� ��������� �������)
    void CreateNewImage(int width, int height);

    // ������� foreground-����
    // (��������� �������� ������
    //  ��� �������� ��������� �������)
    Color ForegroundColor { get; set; }

    // ������� background-����
    // (��������� �������� ������
    //  ��� �������� ��������� �������)
    Color BackgroundColor { get; set; }

    // ������� �������� ������,
    // ���� ��������� �������� ��� - ���������� null
    IPaintPlugin ActivePlugin { get; }

    // �������� ������� �������� ������
    // (�������� ������ ��� ��������� �������)
    void UnselectPlugin();

    // ������������� ������ ��� �������
    // ���������� ����������� (������
    // ����������� � ����� ����� ����������);
    // ���� control=null, �� ���� �������� ������
    // (��������� �������� ������ ��� �������� ��������� �������)
    // (� ���������� ������� ������ ������������ ����������������
    //  ������� ����������, ��������� �� System.Windows.Forms.UserControl)
    Control OptionsControl { get; set; }

    // ������������� ������ �����������
    // ��� ������������
    // (��������� �������� ������
    //  ��� �������� ��������� �������)
    Cursor Cursor { get; set; }
  }
}
