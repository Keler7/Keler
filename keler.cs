[HttpPost]
        public IActionResult AddStudent([FromBody] StudentVM schoolVM)
        {
        
            var school = new School()
            {
                
                FirstName = studentVM.FirstName,
                LastName=studentVM.LastName,
                GraduationYear = studentvm.GraduationYear,
                IsActive = studentVM.IsActive,
                DateOfBirth = studentVM.DateOfBirth,

            };

            
            return Created("", student);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateStudent([FromBody]StudentVM StudentVM, int id)
        {
            
            var student = new Student()
            {
                FirstName = "keler",
                LastName = "uzhuri",
                GraduationYear = "2023",
                IsActive = true,
                DateOfBirth = DateTime.Now.AddYears(-20),
            };


        
            school.Name = schoolVM.Name;
            school.Address = schoolVM.Address;
            school.YearEstablished = schoolVM.YearEstablished;
            school.DateUpdated = DateTime.UtcNow;


            return Ok($"School with id = {id} was updated");
        }