namespace St
{
    public class Sieuthi
    {
        private string id;
        private string diachi;
        private string giamdoc;
        private string tensieuthi;
        private string sdt;

        public string getid(){
            return id;
        }

        public string getdiachi(){
            return diachi;
        }

        public string getgiamdoc(){
            return giamdoc;
        }
        public string gettensieuthi()
        {
            return tensieuthi;
        }
        public string getsdt()
        {
            return sdt;
        }
        public Sieuthi(string id, string tensieuthi, string giamdoc, string diachi, string sdt){
           this.id = id;
           this.tensieuthi = tensieuthi;
           this.giamdoc = giamdoc;
           this.diachi = diachi;
           this.sdt = sdt;
        }

        override public string ToString(){
            return "Sieuthi(" + id + ", " + tensieuthi + ", " + giamdoc + ", " + diachi + ", " + sdt + ")";
        }
        
    }
}