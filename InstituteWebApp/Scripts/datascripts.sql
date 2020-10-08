SET IDENTITY_INSERT [dbo].[Courses] ON 
INSERT [dbo].[Courses] ([CourseID], [CourseName], [CourseFee]) VALUES (1, N'Core Java', 500)
INSERT [dbo].[Courses] ([CourseID], [CourseName], [CourseFee]) VALUES (2, N'Advance Java', 500)
INSERT [dbo].[Courses] ([CourseID], [CourseName], [CourseFee]) VALUES (3, N'Programming Using C++', 400)
SET IDENTITY_INSERT [dbo].[Courses] OFF
SET IDENTITY_INSERT [dbo].[Students] ON 
INSERT [dbo].[Students] ([StudentID], [StudentName], [FatherName], [ContactNo]) VALUES (1, N'Amit Mishra', N'Mr Raman Mishra', N'64099155145')
INSERT [dbo].[Students] ([StudentID], [StudentName], [FatherName], [ContactNo]) VALUES (2, N'Ankit Goyal', N'Mr Ramesh Goyal', N'64099155452')
SET IDENTITY_INSERT [dbo].[Students] OFF
SET IDENTITY_INSERT [dbo].[StudentCourses] ON 
INSERT [dbo].[StudentCourses] ([StudentCourseID], [CourseID], [StudentID], [Fee]) VALUES (1, 1, 1, 400)
INSERT [dbo].[StudentCourses] ([StudentCourseID], [CourseID], [StudentID], [Fee]) VALUES (2, 1, 2, 400)
INSERT [dbo].[StudentCourses] ([StudentCourseID], [CourseID], [StudentID], [Fee]) VALUES (3, 2, 1, 500)
INSERT [dbo].[StudentCourses] ([StudentCourseID], [CourseID], [StudentID], [Fee]) VALUES (4, 3, 2, 700)
SET IDENTITY_INSERT [dbo].[StudentCourses] OFF
SET IDENTITY_INSERT [dbo].[Branches] ON 
INSERT [dbo].[Branches] ([BranchID], [Location], [ContactNo]) VALUES (1, N'Auckland', N'64099144100')
INSERT [dbo].[Branches] ([BranchID], [Location], [ContactNo]) VALUES (2, N'Wellington', N'64049109915')
INSERT [dbo].[Branches] ([BranchID], [Location], [ContactNo]) VALUES (3, N'Christchurch', N'64099155100')
SET IDENTITY_INSERT [dbo].[Branches] OFF