
public class Word
{
    private string _Text;
    private bool _isHidden;

    public Word(string text)
    {
        _Text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return new string('_', _Text.Length);
        }
        else
        {
            return _Text;
        }
    }
}