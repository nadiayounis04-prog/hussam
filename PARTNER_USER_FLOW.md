# PARTNER USER FLOW

## Complete Journey Map for Partner Archetype

### 🚀 **ENTRY POINTS**
1. **Main Chambers Page** → `/chamber`
2. **Direct Partner Chamber** → `/chamber/partner`

---

### 📍 **STEP 1: Partner Chamber Landing**
**URL:** `/chamber/partner`
- **Content:** Partner archetype overview, description, and characteristics
- **Action:** User learns about being a Partner
- **Next:** User clicks "The Path" or "Breaker" button

---

### ⚡ **STEP 2: Breaker Page**
**URL:** `/chamber/partner/breaker`
- **Content:**
  - "Path to Future Self: The Living Bridge"
  - Mythic language about becoming the Living Bridge
  - Field signs and bridge's law
  - 5-minute read with powerful motivation
- **Action:** User clicks "Begin the Bridge's Rite"
- **Next:** Redirects to Payment Gateway

---

### 🛤️ **STEP 3: The Path (Payment Gateway)**
**URL:** `/chamber/partner/the-path`
- **Content:** 
  - "PARTNER — The Bridge of Connection"
  - Payment gateway with $27 fee
  - Motivational content about becoming the bridge
  - Benefits of taking the stage test
- **Action:** User clicks "Become the Bridge — $27"
- **Next:** Redirects to Stage Quiz

---

### 🧠 **STEP 4: Stage Quiz (20 Questions)**
**URL:** `/chamber/partner/breaker/the-path/field-proof/free-walk`
- **Content:**
  - "Stage/Masks Diagnostic Quiz"
  - 20 questions to determine exact stage and mask
  - Progress bar showing completion
  - Partner-themed red/pink styling
- **Action:** User answers all 20 questions
- **Next:** Results page with diagnosis

---

### 📊 **STEP 5: Quiz Results**
**URL:** `/chamber/partner/breaker/the-path/field-proof/free-walk/results`
- **Content:**
  - Stage diagnosis (Mediator, Conflict Resolver, Harmony Seeker, Bridge Builder, Living Bridge)
  - Mask identification
  - Stage progress bars for all 5 stages
  - "Your True Need" section
  - **Single Action Button:** "Recommended Rituals"
- **Action:** User clicks "Recommended Rituals"
- **Next:** Rituals page

---

### 🔮 **STEP 6: Recommended Rituals**
**URL:** `/chamber/partner/rituals`
- **Content:**
  - Stage-specific rituals for progression
  - Practices to move from current stage to next
  - Ritual library with 30+ advanced practices
  - Partner-specific ritual descriptions
- **Action:** User practices rituals to evolve
- **Next:** User can retake quiz to measure progress

---

## 🔄 **ALTERNATIVE FLOWS**

### **Flow A: Standard Journey**
```
Chamber → Breaker → Payment Gateway → Stage Quiz → Results → Rituals
```

### **Flow B: Direct Path (Alternative)**
```
Chamber → The Path → Payment Gateway → Stage Quiz → Results → Rituals
```

### **Flow C: Retake Quiz**
```
Results → Stage Quiz → New Results → Rituals
```

---

## 🎯 **KEY FEATURES**

### **Payment Integration**
- **$27 fee** for stage quiz access
- **Payment gateway** with motivational content
- **Seamless redirect** to quiz after payment

### **Stage Detection**
- **5 stages:** Mediator → Conflict Resolver → Harmony Seeker → Bridge Builder → Living Bridge
- **Mask identification** for each stage
- **Progress tracking** across all stages
- **Personalized diagnosis** with specific needs

### **Ritual System**
- **Stage-specific practices** for progression
- **Advanced ritual library** with 30+ practices
- **Targeted evolution** from current to next stage

### **User Experience**
- **Beautiful UI** with red/pink partner theme
- **Responsive design** for all devices
- **Smooth navigation** between pages
- **Clear call-to-actions** at each step

---

## 📱 **MOBILE EXPERIENCE**
- **Responsive buttons** that stack on mobile
- **Readable text** at all screen sizes
- **Touch-friendly** quiz interface
- **Smooth animations** optimized for mobile

---

## 🎨 **VISUAL THEME**
- **Primary Colors:** Red (#e11d48) and Pink (#ec4899)
- **Background:** Black with subtle gradients
- **Animations:** Pulse effects, glowing borders
- **Typography:** Bold, mystical, motivational

---

## 🔧 **TECHNICAL IMPLEMENTATION**
- **Next.js routing** with dynamic archetype parameters
- **React state management** for quiz progress
- **URL parameters** for quiz results sharing
- **Conditional rendering** for partner-specific content
- **Responsive CSS** with Tailwind

---

## 📈 **CONVERSION OPTIMIZATION**
- **Clear value proposition** at payment gateway
- **Single action button** on results page
- **Motivational language** throughout journey
- **Progress visualization** to show advancement
- **Personalized recommendations** based on results

---

## 🎯 **SUCCESS METRICS**
- **Payment conversion** from gateway to quiz
- **Quiz completion rate** (20 questions)
- **Ritual engagement** after results
- **Return visits** for progress tracking
- **Stage progression** over time

---

## 🌉 **PARTNER-SPECIFIC CONTENT**

### **Payment Gateway Content:**
- **Title:** "PARTNER — The Bridge of Connection"
- **Main Message:** "You Are the Living Bridge Between Worlds"
- **Visual:** Bridge emoji (🌉) with connection energy
- **Investment:** $27 as toll for becoming the bridge
- **Benefits:** Connection rituals and conflict resolution practices
- **CTA:** "Become the Bridge — $27"

### **Stage Progression:**
1. **Mediator** - Basic conflict resolution
2. **Conflict Resolver** - Advanced mediation skills
3. **Harmony Seeker** - Creating harmony in groups
4. **Bridge Builder** - Building lasting connections
5. **Living Bridge** - Becoming the connection reality cannot resist

---

*This flow creates a complete, engaging journey for Partner users to discover their stage, understand their mask, and access targeted rituals for evolution.* 