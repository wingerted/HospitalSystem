using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using HospitalSystem.Models.Mapping;

namespace HospitalSystem.Models
{
    public partial class teamworkContext : DbContext
    {
        static teamworkContext()
        {
            Database.SetInitializer<teamworkContext>(null);
        }

        public teamworkContext()
            : base("Name=teamworkContext")
        {
        }

        public DbSet<adjust_price_record> adjust_price_record { get; set; }
        public DbSet<allocate_record> allocate_record { get; set; }
        public DbSet<appointment_record> appointment_record { get; set; }
        public DbSet<approve_record> approve_record { get; set; }
        public DbSet<charge_record> charge_record { get; set; }
        public DbSet<department> departments { get; set; }
        public DbSet<doctor> doctors { get; set; }
        public DbSet<examine_detail> examine_detail { get; set; }
        public DbSet<examine_list> examine_list { get; set; }
        public DbSet<examine_product> examine_product { get; set; }
        public DbSet<inbound_records> inbound_records { get; set; }
        public DbSet<medical_record> medical_record { get; set; }
        public DbSet<medicine> medicines { get; set; }
        public DbSet<medicine_detail> medicine_detail { get; set; }
        public DbSet<medicine_inventory> medicine_inventory { get; set; }
        public DbSet<outbound_records> outbound_records { get; set; }
        public DbSet<patient> patients { get; set; }
        public DbSet<prescription> prescriptions { get; set; }
        public DbSet<purchase_record> purchase_record { get; set; }
        public DbSet<register_list> register_list { get; set; }
        public DbSet<staff> staffs { get; set; }
        public DbSet<withdraw_medicine_record> withdraw_medicine_record { get; set; }
        public DbSet<withdraw_registration_record> withdraw_registration_record { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new adjust_price_recordMap());
            modelBuilder.Configurations.Add(new allocate_recordMap());
            modelBuilder.Configurations.Add(new appointment_recordMap());
            modelBuilder.Configurations.Add(new approve_recordMap());
            modelBuilder.Configurations.Add(new charge_recordMap());
            modelBuilder.Configurations.Add(new departmentMap());
            modelBuilder.Configurations.Add(new doctorMap());
            modelBuilder.Configurations.Add(new examine_detailMap());
            modelBuilder.Configurations.Add(new examine_listMap());
            modelBuilder.Configurations.Add(new examine_productMap());
            modelBuilder.Configurations.Add(new inbound_recordsMap());
            modelBuilder.Configurations.Add(new medical_recordMap());
            modelBuilder.Configurations.Add(new medicineMap());
            modelBuilder.Configurations.Add(new medicine_detailMap());
            modelBuilder.Configurations.Add(new medicine_inventoryMap());
            modelBuilder.Configurations.Add(new outbound_recordsMap());
            modelBuilder.Configurations.Add(new patientMap());
            modelBuilder.Configurations.Add(new prescriptionMap());
            modelBuilder.Configurations.Add(new purchase_recordMap());
            modelBuilder.Configurations.Add(new register_listMap());
            modelBuilder.Configurations.Add(new staffMap());
            modelBuilder.Configurations.Add(new withdraw_medicine_recordMap());
            modelBuilder.Configurations.Add(new withdraw_registration_recordMap());
        }
    }
}
