#------------------------ WESTMINSTER INTERNATIONAL UNIVERSITY IN TASHKENT -----------------------#
#-------------------------- INTRODUCTION TO STATISTICS AND DATA SCIENCE --------------------------#
#------------------------------- PORTFOLIO OF INDIVIDUAL EXERCISES -------------------------------#

ID <- 9115       # TO DO: <--- Insert your ID in front of the hash sign. Do not include the zeros (0's) in the beginning of your ID.
# For example, if your ID is 00010200, then you need to enter your ID as 10200.
# Failure to provide the ID results in 0 mark. 

# Some exercises require the student to insert his/her last 4 digits of ID as abcd = 9115. 
# A student with an ID of 0123 as the last four digits has the following values: a = 0, b = 1, c = 2, d = 3.
# You only must provide the R code which will store the correct answer in the given variable names. DO NOT use rounding functions for your answers.
# You can add additional rows before the answer line if you have more than one line of code.
# But you must store the final code into the provided variable names for each task.
# You can use any packages in R you want to solve these tasks.  
# DO NOT CHANGE THE VARIABLE NAMES (e.g. answer1, answer2, etc). We will only give full marks if your code provides the correct answer. 
# There is no partial credit for these tasks.

#--------------------------------------PACKAGE INSTALLATION AND LOADING PART-----------------------# 
# Skip this part if you are only using the Base package of R.
# If you use any packages other than the base package, 
# please add the installation and loading codes here


#-------------------------------------END OF PACKAGE INSTALLATIONS AND LOADING---------------------# 

#------ TASK 1 -------# [5 marks]
# Oriyat FM, a radio station, finds that the distribution of the lengths of time listeners
# are tuned to the station follows the normal distribution. The mean of the
# distribution is 39.0 minutes and the standard deviation is 4.1 minutes. What is the
# probability that a particular listener will tune in between 31.0 and 45.0 minutes?

answer1 <- pnorm(45, mean = 39, sd = 4.1) - pnorm(31, mean = 39, sd = 4.1)   # TO DO: replace NULL with your correct code.

# P(31 < x < 45) = P(x < 45) - P(x > 31)
# To find the probability of normal distribution ranging between two values, 
# we need to subtract the cumulative probability of the lower value from the higher value's one.
# Thus I used the function of pnorm which is for cumulative probability.

#------ TASK 2 -------# [5 marks]

# Light bulbs are tested for their life-span. It is found that 11% of the light bulbs are rejected.
# A random sample of 50 bulbs is taken from stock and tested. The random variable X is the number of bulbs that are rejected.
# What is the probability that the value of X is at least 5? 

answer2 <-  1 - pbinom(4, 50, 0.11)   # TO DO: replace NULL with your correct code.

# P(x ??? 5) = 1 - (P ??? 4)
# To find the probability of continuous binomial distribution we should use pbinom.
# As this function calculates the cumulative probability, lower.tail has been set to FALSE equal to subtracting from 1.

#------ TASK 3 -------# [5 marks]

# It is estimated that 1825 of the callers to the Customer Service department of Dell Inc. will receive a busy signal per year. 
# Suppose the number of customers who receive a busy signal follows a Poisson distribution. Assume there are 365 days in a year.
# What is the probability that at least 6 will receive a busy signal in a single day?

answer3 <- 1 - ppois(q = 5, lambda = 1825/365)   # TO DO: replace NULL with your correct code.

# P(x ??? 6) = 1 - P(x = 5)
# To find the probability of continuous poison distribution we should use ppois.
# As it calculates the cumulative probability, we should subtract the value from 1 to find the needed probability.
# lambda is equal to [1825/365] because 1825 is yearly but we need daily mean.

#------ TASK 4 -------# [10 marks]

# The closing price of Schnur Sporting Goods Inc. common stock is uniformly distributed
# between $21 and $45 per share. 
# 1. What is the probability that the stock price will be less than $35?

answer4_1 <- punif(35, min = 21, max = 45)   # TO DO: replace NULL with your correct code.

# P(x < 35)
# To find the probability of continuous uniform distribution we should use punif.

# 2. What is the probability that the stock price will be less than $35 if we know for sure it will be greater than $30?

answer4_2 <- (punif(35, min = 21, max = 45) - punif(30, min = 21, max = 45)) / (1 - punif(30, min = 21, max = 45))   # TO DO: replace NULL with your correct code.

# P(A | B) = P(A and B) / P(B) = (P(A) - P(B)) / P(B)
# To find the probability of uniform distribution with a given condition we should use punif and the formula above.

#------- TASK 5 -------# [5 marks]

# The price of shares of Bank of America Corp at the end of each trading day for the last year
# followed the normal distribution. Assume there were 240 trading days in the year. The
# mean price was $35.00 per share and the standard deviation was $2.91 per share.
# What is the minimum share price for the top 15% of end-of-day trading prices?

answer5 <- qnorm(0.85, mean = 35, sd = 2.91)   # TO DO: replace NULL with your correct code.

# Finding the certain area of the distribution helps to identify the minimum of certain percentile. 
# The point defining the 0.85 percentile also defines the minimum value of top 15%.

#------- TASK 6 -------# [12 marks]
# Majesty Video Production Inc. wants the mean length of its advertisements to be 31 seconds.
# Assume the distribution of ad length follows positively skewed distribution with a
# population standard deviation of 2.5 seconds. Suppose we select a sample of 36 ads
# produced by Majesty.
# 1. What is the standard error of the mean time?
answer6_1 <- 2.5 / sqrt(36) # TO DO: replace NULL with your correct code.

# Using the formula of st_error = sd / sqrt(n) we can calculate the standard error.

# 2. What percent of the sample means will be greater than 31.25 seconds?
answer6_2 <- pnorm(31.25, mean = 31, sd = 2.5 / sqrt(36)) # TO DO: replace NULL with your correct code.

# We can use the standard error into the sd with the function of pnorm to solve this problem.
# As it says greater, we should subtract the cumulative probability of certain value from 1.

# 3. What is the length of advertisement (in seconds) on the 80th percentile?

answer6_3 <- qnorm(0.8, mean = 31, sd = 2.5) # TO DO: replace NULL with your correct code.

# To find the value of certain percentile, we should use the function of qnorm.

#------- TASK 7 -------# [9 marks]
# Let's import a dataset using R's built-in data loading function (i.e., see ?data); 
# We will load the iris data set, which is a famous data set involving iris flower species.
data(iris) # load the "iris" data.frame object into the current session
head(iris) # provides the first 6 rows of this dataset.
# 1. Count the number of observations in this dataset.

answer7_1 <- nrow(iris) # TO DO: replace NULL with your correct code. 

# Calculating the number of rows available in the data set which is equal to the number of observations.

# 2. Calculate the mean petal lengths of only the "setosa" flowers.

answer7_2 <- mean(iris$Petal.Length[iris$Species == "setosa"]) # TO DO: replace NULL with your correct code.

# Firstly, we should extract the data with the value of "setosa" in the column of Species
# Then we should choose the values of the column of Petal.Length
# Lastly we can use mean() function to calculate the average of these values.

# 3. Calculate the standard deviation of sepal lengths of only the "virginica" flowers.

answer7_3 <- sd(iris$Sepal.Length[iris$Species == "virginica"]) # TO DO: replace NULL with your correct code.

# Firstly, we should extract the data with the value of "virginica" in the column of Species
# Then we should choose the values of the column of Sepal.Length
# Lastly we can use sd() function to calculate the standard deviation of these values.


#------- TASK 8 -------# [20 marks: questions 1 through 5 - 3 marks each, question 6 - 5 marks]
# Let's import the Titanic data set, which is a famous data set involving passengers of Titanic Cruiseship.
dat <- read.csv(url("https://web.stanford.edu/class/archive/cs/cs109/cs109.1166/stuff/titanic.csv"))
# You can learn more about each variable from the following link: https://www.kaggle.com/c/titanic/data
# by checking out the Data Library.
# You can add extra rows if needed on top of each answer line, but your code which provides the final answer must
# be provided in the provided answer lines.
# If NAs are present in the dataset, they should be removed before answering the questions.
head(dat) # you can see the first 6 rows of your Titanic dataset

#1 Write the code that provides the percentage of female passengers who perished.

# COMMAS AT THE END OF EVERY EXPRESSION BELOW ARE PRESENT TO IGNORE THE NA VALUES

females <- dat[dat$Sex == "female", ] # extracting the data of females
females_amount <- nrow(females) # calculating the amount of females

females_perished <- females[females$Survived == 0, ] # extracting the data of perished females out of females data set
females_perished_amount <- nrow(females_perished) # calculating the number of perished females

answer8_1 <- (females_perished_amount /  females_amount) * 100 # TO DO: replace NULL with your correct code.

# calculating the percentage of perished females in contrast to survived females

#2 How many passengers aged 17 and below were perished in this disaster?

seventeen_and_below <- dat[dat$Age <= 17, ] # extracting the data of passengers aged 17 and below

seventeen_and_below_perished <- seventeen_and_below[seventeen_and_below$Survived == 0, ] # extracting the data of perished passengers out of those aged 17 and below

answer8_2 <- nrow(seventeen_and_below_perished) # TO DO: replace NULL with your correct code.

# calculating the amount of perished 17 and less years old passengers

#3 What percentage of passengers from 1st class have survived?

firstclass <- dat[dat$Pclass == 1, ] # extracting the data of 1st class passengers
firstclass_amount <- nrow(firstclass) # calculating the amount of 1st class passengers

firstclass_survived <- firstclass[firstclass$Survived == 1, ] # extracting the data of perished passengers out of 1st class passengers
firstclass_survived_amount <- nrow(firstclass_survived) # calculating the amount of perished and 1st class passengers

answer8_3 <- (firstclass_survived_amount /  firstclass_amount) * 100 # TO DO: replace NULL with your correct code.

# calculating the percentage of perished and 1st class passengers in contrast to survived 1st class passengers

#4 Calculate the average fare amount of the passengers who were males and were in the 3rd class.

males <- dat[dat$Sex == "male", ] # extracting the data of males
males_thirdclass <- males[males$Pclass == 3, ] # extracting the data of 3rd class males out of males data set

answer8_4 <- mean(males_thirdclass$Fare) # TO DO: replace NULL with your correct code.

# calculating the average fare of 3rd class male passengers using the mean() function

#5 Calculate the average fare amount of the adult passengers (aged 18 or above) who were in the 2nd class or were females.

adult <- dat[dat$Age >= 18, ] # extracting the data of adults
adult_secondclass_or_female <- adult[adult$Pclass == 2 | adult$Sex == 'female', ] # extracting the data of 2nd class OR female passengers. Here | can be used to define an operator of OR.

answer8_5 <- mean(adult_secondclass_or_female$Fare) # TO DO: replace NULL with your correct code.

# calculating the average fare of adult 2nd class males and adult females using the mean() function

#6 Calculate the average age of those passengers who have a title of "Miss" in their names and do not have parents/children aboard.

miss <- dat[grep("Miss", dat$Name), ] # extracting the passengers with "Miss" in their names. A function grep() helps to select certain values containing the given value.
miss_noparentchild <- miss[miss$Parents.Children.Aboard == 0, ] # extracting the ones who have no parent and child abroad out of the data above.

answer8_6 <- mean(miss_noparentchild$Age) # TO DO: replace NULL with your correct code.

# calculating the average age of passengers who has "Miss" in their names and no parent/child abroad using the mean() function


#------- TASK 9 -------# [10 marks]
set.seed(9115) # TO DO: insert your last four digits instead of 1234.
companies <- c("Kroger Co", "Cisco Systems", "WellsFargo & Co", "Bank of America Corp", "Norwegian Cruise Line Holdings Ltd", "Delta Air Lines Inc", "Pfizer Inc", "American Airlines Group Inc", "ConocoPhillips")
rlist <- as.vector(sample(companies, 3))       # run these 4 lines of code ONLY ONCE to get random three company names.
cat("Your company list:", rlist, sep = "   ")  # this line of code prints the names of 3 companies that you use for your plot.
# For this task, you need to randomly select 3 companies out of the company list provided above.
# Then, import stock price data from Yahoo Finance (finance.yahoo.com) for each of three companies from Jan 1, 2016 to Feb 5, 2021 (c, d - your ID values).
# Hint: you can either use Quantmod package or manually download from Yahoo Finance for each stock and import to R Studio)
# Convert the daily stock data to Weekly data (only last trading day of each week will be stored) and plot a line graph showing all three stock prices in one plot.
# Use the column for Close Price in y axis of your graph and use three different colors for the lines.
# Use ylim option to make sure all 3 lines are visible in your plot for the whole period.
# Use legend option to place a legend on an empty spot of your graph.

KR <- read.csv("./KR.csv")
DAL <- read.csv("./DAL.csv")
NCLH <- read.csv("./NCLH.csv")


KRdata <- data.frame(
  x = factor(x = KR$Date),
  y = KR$Close
)

DALdata <- data.frame(
  x = factor(x = DAL$Date),
  y = DAL$Close
)

NCLHdata <- data.frame(
  x = factor(x = NCLH$Date),
  y = NCLH$Close
)


plot(y ~ x, data = KRdata, type = "l")
lines(y ~ x, data = DALdata, type = "l")
lines(y ~ x, data = NCLHdata, type = "l")


#------- TASK 10 -------# [10 marks]

# Create a function named "refer_list" which takes a dataframe as an argument and prints only the ids whose marks are lower than 40.
# For example, if we pass the following dataframe, "students" as shown below, as an argument into the "refer_list" function, 
# the function must print the following ID's: 6234, 5786. The data type of the output is not important. 
# If we make any change to the "students" data frame, your function should still work properly with the new data.
students <- data.frame("id" = c(6234, 6235, 5786, 5250), "mark" = c(38, 55, 20, 44))

refer_list <-  function() {
  return(students$id[students$mark < 40]) 
  # firstly the indexes of values below 40 in "mark" vector are identified 
  # using these indexes the corresponding values of "id" vector are selected and returned
}             

print(refer_list()) # the IDs are being printed to the console

# TO DO: fill in the code to create the function
# TO DO: <--- Your code goes here

answer10 <- refer_list()

#------- TASK 11 -------# [6 marks]
# The following paragraph consists of some meaningful statements. But some of the letters were replaced with characters.
# Your task is to replace those characters programmatically to the appropriate letters and provide the final meaningful statement.
# Please pay attention to upper/lower cases.

statement <- "!;, [SDS t;+m, h~p; th+t }~u ;nj~};d }~ur ;x;rcis;s +nd w;r; +bl; t~ c~mpl;t; th;m ~n tim;. Pl;+s; s+v; }~ur fil; in R ;xt;nsi~n +nd d~ n~t f~rg;t t~ r;n+m; th; fil; with }~ur ~wn [D. [t is tim; t~ h+v; + g~~d r;st +nd c~m; t~ }~ur cl+ss;s with fr;sh mind. S;; }~u n;xt tim; in th; cl+ss."
# First of all, I identified what character should be changed to the correct one as follows:
# ! = W
# ; = e
# [ = I
# + = a
# ~ = o
# } = y

# TO DO: Add more rows here if needed.
answer11 <- chartr(old = " ! ; [ + ~ } ", new=" W e I a o y ", statement) # TO DO: Use R code to replace these characters with correct letters and save your final statement in the "answer11".

# I used chartr(old, new, x) function which replaces the characters of "old" with characters in "new" in the data of "x" which is a "statement"

#------- TASK 12 -------# [3 marks]
# Provide your constructive feedback with few sentences about ISDS module. Use the print() function to provide your feedback :).
# TO DO: Your feedback should be printed using print() function.

print("As a BIS student, the first semester of ISDS impressed negatively with only practical and theorethical topics. During the first part of Semester 2, we learned how to apply the statistical skills using the R programming language which was enjoying for programmers. I am leaving all the best feedback as at least, I benefited a lot so far. Olmos aka alongside Gulomjon aka were the reasons of us gaining very good statistics skills which we will be using during the rest of our lives. Being a yet difficult, with great tutors, the topics were not challenging to understand. Thank you! Regards, 00009115")
# Huh, I am done with that. Well, we were asked to type comments for ALL task which I am doing ;). Thank you and see you in coming and hopefully great seminars.


#-------------------------------------------------------------- END OF TASKS --------------------------------------------------------------------------------#
#--------------------------------------------------------------- GOOD LUCK!----------------------------------------------------------------------------------#